using System.Configuration;
using System.Data;
using System.Data.SqlClient;



namespace ControlParqueoApp
{
    public partial class FormLogin : Form
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["ControlParqueoConnectionString"].ConnectionString;
        public FormLogin()
        {
            InitializeComponent();
            txtuser.MaskInputRejected += txtuser_MaskInputRejected;
            connectionString = ConfigurationManager.ConnectionStrings["ControlParqueoConnectionString"].ConnectionString;
        }
        private void txtuser_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
            MessageBox.Show("Entrada de usuario inv�lida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "Usuario")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "Usuario";
                txtuser.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Contrase�a")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Contrase�a";
                txtpass.ForeColor = Color.Silver;
                txtpass.UseSystemPasswordChar = false;
            }
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtuser.Text;
            string contrase�a = txtpass.Text;
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string query = "SELECT Rol FROM Usuarios WHERE Usuario = @Usuario AND Contrase�a = @Contrase�a";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Contrase�a", contrase�a);

                    string rol = cmd.ExecuteScalar() as string;

                    if (rol == "admin")
                    {
                        FormPrincipalAdmin formPrincipalAdmin = new FormPrincipalAdmin(conexion);
                        formPrincipalAdmin.Show();
                        this.Hide();
                    }
                    else if (rol == "usuario")
                    {
                        FormPrincipalUsuario formPrincipalUsuario = new FormPrincipalUsuario();
                        formPrincipalUsuario.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contrase�a incorrectos. Por favor, intenta de nuevo.", "Error de inicio de sesi�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de conexi�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
    
