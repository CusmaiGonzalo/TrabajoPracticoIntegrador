using BE;
using BLL;
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
    public partial class FormularioUsuarios : Form, IObserver
    {
        BLL.GestionUsuarios gestorUsuarios;
        BLL.GestionIdioma gestorIdioma;
        BLL.GestionPermisos gestorPermisos;
        public FormularioUsuarios(GestionIdioma idiomasFormPrincipal)
        {
            InitializeComponent();
            gestorUsuarios = new BLL.GestionUsuarios();
            gestorPermisos = new BLL.GestionPermisos();
            gestorIdioma = idiomasFormPrincipal;
            gestorIdioma.Agregar(this);
            Traducir(gestorIdioma.IdiomaActual);
            PATENTE permisoAgregaruUsuario = new PATENTE() { IDPatente = 5 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoAgregaruUsuario, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_agregarUs.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
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


        private void FormularioUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            gestorIdioma.Quitar(this);
        }


        public void Traducir(int nuevoIdioma)
        {
            TraducirAIdiomaControles(this.Controls, nuevoIdioma);
        }
        private void TraducirAIdiomaControles(Control.ControlCollection controles, int idioma)
        {
            foreach (Control control in controles)
            {
                control.Text = gestorIdioma.ObtenerTraduccion(control.Name);
                if (control.HasChildren)
                {
                    TraducirAIdiomaControles(control.Controls, idioma);
                }
            }
        }

        private void FormularioUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
