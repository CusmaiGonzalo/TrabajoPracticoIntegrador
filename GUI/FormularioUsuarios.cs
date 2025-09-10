using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormularioUsuarios : Form
    {
        BLL.GestionUsuarios gestorUsuarios;
        public FormularioUsuarios()
        {
            gestorUsuarios = new BLL.GestionUsuarios();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text != "" && textBox2.Text != "")
                {
                    BE.USUARIO nuevoUsuario = new BE.USUARIO();
                    nuevoUsuario.NombreUsuario = textBox1.Text;
                    nuevoUsuario.Contraseña = textBox2.Text;
                    gestorUsuarios.AgregarUsuario(nuevoUsuario);
                }
                else { throw new Exception("Complete todos los datos"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
