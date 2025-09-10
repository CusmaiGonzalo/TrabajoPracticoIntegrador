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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            AbrirFormulario<FormularioUsuarios>();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            SessionManager.LogOut();
            this.Close();

        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormularioUsuarios>();
        }

        private void AbrirFormulario<T>() where T : Form, new()
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is T)
                {
                    form.Activate();
                    return;
                }
            }

            T formulario = new T();
            formulario.MdiParent = this;
            formulario.WindowState = FormWindowState.Maximized;
            formulario.Show();
        }
    }
}
