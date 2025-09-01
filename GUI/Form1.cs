namespace GUI
{
    public partial class Form1 : Form
    {
        BLL.GestionUsuarios GestorUsuarios;
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
                    GestorUsuarios.LogearUsuario(user);

                    this.Hide();
                    FormPrincipal formPrincipal = new FormPrincipal();
                    formPrincipal.ShowDialog();
                    this.Close();
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
