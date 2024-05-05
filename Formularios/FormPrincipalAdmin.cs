using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ControlParqueoApp.Formularios;
using ControlParqueoApp.Clases;
using Microsoft.VisualBasic;
using System.Configuration;

namespace ControlParqueoApp
{
    public partial class FormPrincipalAdmin : Form
    {
        public List<Vehiculo> vehiculosIngresados = new List<Vehiculo>();
        public List<Vehiculo> vehiculosSalidos = new List<Vehiculo>();


        private SqlConnection conexion;


        public FormPrincipalAdmin(SqlConnection connection)
        {
            InitializeComponent();
            this.conexion = connection;
            this.vehiculosIngresados = new List<Vehiculo>();

        }

        private void btnRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            // Verificamos si el formulario ya está abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormRegistrarVehiculo)
                {
                    // Si está abierto, lo traemos al frente
                    form.BringToFront();
                    return;
                }
            }
            string connectionString = @"Data Source=DESKTOP-1UEAB8J\SQLEXPRESS;Initial Catalog=ControlParqueo;Integrated Security=True;";
            SqlConnection conexion = new SqlConnection(connectionString);

            // Si no está abierto, lo creamos y lo mostramos
            FormRegistrarVehiculo formRegistrarVehiculo = new FormRegistrarVehiculo(conexion, vehiculosIngresados);
            formRegistrarVehiculo.ShowDialog();
        }

        private void btnSalidaVehiculo_Click(object sender, EventArgs e)
        {
            // Obtenemos la placa ingresada por el usuario
            string placa = Interaction.InputBox("Ingrese el número de placa:", "Salida de Vehículo", "");

            if (string.IsNullOrEmpty(placa))
                return;

            try
            {
                string connectionString = @"Data Source=DESKTOP-1UEAB8J\SQLEXPRESS;Initial Catalog=ControlParqueo;Integrated Security=True;";
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    // Buscamos el vehículo en la base de datos
                    string query = "SELECT * FROM Vehiculos WHERE Placa = @Placa";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Placa", placa);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows) // Verificar si hay filas antes de intentar leer
                        {
                            reader.Read(); // Leer la primera fila
                            string nombrePropietario = reader["NombrePropietario"].ToString();
                            DateTime horaIngreso = Convert.ToDateTime(reader["HoraIngreso"]);

                            // Cerrar el lector de datos después de leer los datos necesarios
                            reader.Close();

                            // Registramos la hora de salida
                            DateTime horaSalida = DateTime.Now;

                            // Agregamos el vehículo a la lista de vehículos salidos
                            vehiculosSalidos.Add(new Vehiculo(placa, nombrePropietario, horaIngreso, horaSalida));

                            // Eliminamos el vehículo de la lista de vehículos ingresados
                            vehiculosIngresados.RemoveAll(v => v.Placa == placa);

                            // Eliminamos el vehículo de la base de datos
                            query = "DELETE FROM Vehiculos WHERE Placa = @Placa";
                            cmd = new SqlCommand(query, conexion);
                            cmd.Parameters.AddWithValue("@Placa", placa);
                            cmd.ExecuteNonQuery();

                            // Generamos e imprimimos el ticket de salida
                            TimeSpan duracion = horaSalida - horaIngreso;
                            string ticket = $"Nombre: {nombrePropietario}\r\n" +
                                            $"Hora de ingreso: {horaIngreso}\r\n" +
                                            $"Hora de salida: {horaSalida}\r\n" +
                                            $"Duración: {duracion.TotalMinutes} minutos";

                            MessageBox.Show(ticket, "Ticket de Salida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MessageBox.Show("Salida registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un vehículo con la placa ingresada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la salida del vehículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ImprimirListadoPrimeroUltimo()
        {
            // Ordenar la lista de vehículos por hora de ingreso
            vehiculosIngresados.Sort((v1, v2) => v1.HoraIngreso.CompareTo(v2.HoraIngreso));

            // Generar el listado de las personas que ingresaron primero al parqueo
            string primero = "Listado de personas que ingresaron primero al parqueo:\n";
            for (int i = 0; i < vehiculosIngresados.Count; i++)
            {
                primero += $"{i + 1}. {vehiculosIngresados[i].NombrePropietario}\n";
            }

            // Generar el listado de las personas que ingresaron últimas al parqueo
            string ultimo = "\nListado de personas que ingresaron últimas al parqueo:\n";
            for (int i = vehiculosIngresados.Count - 1; i >= 0; i--)
            {
                ultimo += $"{vehiculosIngresados.Count - i}. {vehiculosIngresados[i].NombrePropietario}\n";
            }

            MessageBox.Show(primero + ultimo, "Reportes de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CargarVehiculosEnParqueo()
        {
            string connectionString = @"Data Source=DESKTOP-1UEAB8J\SQLEXPRESS;Initial Catalog=ControlParqueo;Integrated Security=True;";
            using (SqlConnection conexion = new SqlConnection(connectionString))

                try
                {
                    conexion.Open();

                    string query = "SELECT NombrePropietario, Placa, HoraIngreso FROM Vehiculos WHERE HoraSalida IS NULL";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    SqlDataReader reader = cmd.ExecuteReader();

                    dataGridViewVehiculos.Rows.Clear();

                    while (reader.Read())
                    {
                        string nombrePropietario = reader["NombrePropietario"].ToString();
                        string placa = reader["Placa"].ToString();
                        DateTime horaIngreso = (DateTime)reader["HoraIngreso"];

                        dataGridViewVehiculos.Rows.Add(nombrePropietario, placa, horaIngreso.ToString("HH:mm:ss"));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los vehículos en el parqueo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.Close();
                }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            ImprimirListadoPrimeroUltimo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarVehiculosEnParqueo();
        }

        private void dataGridViewVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
