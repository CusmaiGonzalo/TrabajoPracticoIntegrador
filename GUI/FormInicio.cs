using BE;
using BLL;
using Servicios;
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
    public partial class FormInicio : Form, IObserver
    {
        BLL.GestionIdioma gestorIdioma = new BLL.GestionIdioma();
        public FormInicio(GestionIdioma idiomasFormPrincipal)
        {
            InitializeComponent();
            gestorIdioma = idiomasFormPrincipal;
            gestorIdioma.Agregar(this);
            Traducir(gestorIdioma.IdiomaActual);
            label_usuario.Text = $"{SessionManager.Instance.UsuarioLog.NombreUsuario}";
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            label_usuario.Text = $"{SessionManager.Instance.UsuarioLog.NombreUsuario}";
        }
        private void FormInicio_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
