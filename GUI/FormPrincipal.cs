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
    public partial class FormPrincipal : Form
    {
        BE.BITACORA nuevaBitacora = new BE.BITACORA();
        GestionBitacora gestorBitacora = new GestionBitacora();
        GestionNegocio gestorNegocio = new GestionNegocio();
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
                    gestorBitacora.RegistrarBitacora(nuevaBitacora);
                    SessionManager.LogOut();
                }
            }
            catch (Exception ex)
            {
                nuevaBitacora = Bitacora.ErrorBitacora($"Error al desloguear: {ex.Message}");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            nuevaBitacora = Bitacora.EventoBitacora("Usuario deslogueado");
            gestorBitacora.RegistrarBitacora(nuevaBitacora);
            SessionManager.LogOut();
            this.Close();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormularioUsuarios>();
        }

        private void eVENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormEventos>();
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormProductos>();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                if (Servicios.DigitoVerificador.VerificarIntegridadDVH(gestorNegocio.ListarDVH()) == false || Servicios.DigitoVerificador.VerificarIntegridadDVV(gestorNegocio.ListarDVV()) == false)
                {
                    throw new Exception("La integridad de los datos ha sido comprometida. Se cerrará la sesión.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                nuevaBitacora = Bitacora.EventoBitacora("Error al verificar la integridad de los datos.");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
                SessionManager.LogOut();
                this.Close();

            }
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
