using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlParqueoApp.Formularios;
using ControlParqueoApp.Clases;
using Microsoft.VisualBasic;


namespace ControlParqueoApp.Formularios
{
    public partial class FormRegistrarVehiculo : Form
    {
        private List<Vehiculo> vehiculosIngresados;
        private SqlConnection conexion;
        private bool esDama; // Variable para almacenar si es parqueo de damas

        public FormRegistrarVehiculo(SqlConnection conexion, List<Vehiculo> vehiculosIngresados)
        {
            InitializeComponent();


            this.conexion = conexion;
            this.vehiculosIngresados = vehiculosIngresados;
            // Suscribimos el evento CheckedChanged del RadioButton
            rbDama.CheckedChanged += RbDama_CheckedChanged;

        }

        private void RbDama_CheckedChanged(object sender, EventArgs e)
        {
            esDama = rbDama.Checked;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            // Validamos que se haya seleccionado un tipo de parqueo
            if (!rbDama.Checked && !rbCaballero.Checked)
            {
                MessageBox.Show("Por favor seleccione el tipo de parqueo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string placa = txtPlaca.Text;
            string nombrePropietario = txtNombrePropietario.Text;

            if (string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(nombrePropietario))
            {
                MessageBox.Show("Por favor ingrese la placa y el nombre del propietario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                conexion.Open();

                // Determinamos el tipo de parqueo
                string parqueo = esDama ? "Damas" : "Caballeros";

                string query = "INSERT INTO Vehiculos (Placa, NombrePropietario, HoraIngreso, Parqueo) VALUES (@Placa, @NombrePropietario, @HoraIngreso, @Parqueo)";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@Placa", placa);
                cmd.Parameters.AddWithValue("@NombrePropietario", nombrePropietario);
                cmd.Parameters.AddWithValue("@HoraIngreso", DateTime.Now);
                cmd.Parameters.AddWithValue("@Parqueo", parqueo);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Vehículo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Creamos un nuevo objeto Vehiculo
                Vehiculo nuevoVehiculo = new Vehiculo(placa, nombrePropietario, DateTime.Now, DateTime.MinValue);

                // Agregamos el nuevo vehículo a la lista de vehículos ingresados
                vehiculosIngresados.Add(nuevoVehiculo);


                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el vehículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }

        }

        private void LimpiarCampos()
        {
            txtPlaca.Clear();
            txtNombrePropietario.Clear();
            // Desmarcamos los RadioButtons
            rbDama.Checked = false;
            rbCaballero.Checked = false;
        }
    }

}

