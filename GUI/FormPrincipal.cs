using DAL;
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
        BE.BITACORA nuevaBitacora = new BE.BITACORA();
        mapper_bitacora maperBitacora = new mapper_bitacora();
        public FormPrincipal()
        {
            InitializeComponent();
            AbrirFormulario<FormularioUsuarios>();
            
            // Añadir manejador para el cierre del formulario
            this.FormClosing += FormPrincipal_FormClosing;
        }

        // Nuevo método para manejar el cierre del formulario
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // Solo deslogueamos si no se cerró a través del botón de logout
                // (que ya tiene su propia lógica de deslogueo)
                if (e.CloseReason != CloseReason.ApplicationExitCall)
                {
                    nuevaBitacora = Bitacora.EventoBitacora("Usuario deslogueado por cierre de ventana");
                    maperBitacora.Insertar(nuevaBitacora);
                    SessionManager.LogOut();
                }
            }
            catch (Exception ex)
            {
                nuevaBitacora = Bitacora.ErrorBitacora($"Error al desloguear: {ex.Message}");
                maperBitacora.Insertar(nuevaBitacora);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            nuevaBitacora = Bitacora.EventoBitacora("Usuario deslogueado");
            maperBitacora.Insertar(nuevaBitacora);
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
