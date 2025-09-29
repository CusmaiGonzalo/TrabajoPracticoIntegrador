using Servicios;

namespace GUI
{
    public partial class Form1 : Form
    {
        BLL.GestionUsuarios GestorUsuarios;
        BE.BITACORA nuevaBitacora = new BE.BITACORA();
        int contadorIntentos = 0;
        public Form1()
        {
            InitializeComponent();
            GestorUsuarios = new BLL.GestionUsuarios();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(textbox_nombreus.Text != "" && textBoxContraseña.Text != "")
                {
                    BE.USUARIO user = new BE.USUARIO();
                    user.NombreUsuario = textbox_nombreus.Text;
                    user.Contraseña = textBoxContraseña.Text;
                    

                    contadorIntentos++;
                    labelIntentos.Text = $"Se han realizado {contadorIntentos} intentos.";
                    if(contadorIntentos > 3)
                    {
                        nuevaBitacora = Bitacora.ErrorBitacora("Demasiados intentos. LogIn bloqueado.");
                        GestorUsuarios.EscribirBitacora(nuevaBitacora);
                        buttonLogin.Enabled = false;
                        labelIntentos.Text += " Comunicarse con admin.";
                    }

                    GestorUsuarios.LogearUsuario(user);
                    contadorIntentos = 0;
                    labelIntentos.Text = "";
                    
                    this.Hide();
                    FormPrincipal formPrincipal = new FormPrincipal();
                    formPrincipal.FormClosed += (s, args) => this.Show();
                    formPrincipal.Show();
                }
                else
                {
                    throw new Exception("Debe completar los campos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
