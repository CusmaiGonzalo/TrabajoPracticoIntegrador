using BE;
using BLL;
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
    public partial class FormPrincipal : Form, IObserver
    {
        BE.BITACORA nuevaBitacora = new BE.BITACORA();
        GestionBitacora gestorBitacora = new GestionBitacora();
        GestionNegocio gestorNegocio = new GestionNegocio();
        GestionIdioma gestorIdioma = new GestionIdioma();
        GestionPermisos gestorPermisos = new GestionPermisos();

        public FormPrincipal()
        {
            InitializeComponent();

            LLenarComboBox(comboBox_idioma, gestorIdioma.ListarIdiomas());
            gestorIdioma.CambiarIdioma(1);
            gestorPermisos.CargarPermisosUsuario(SessionManager.Instance.UsuarioLog);

            PATENTE permisoInicio = new PATENTE() { IDPatente = 3 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoInicio, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                iNICIOToolStripMenuItem.Visible = false;
            }
            else
            {
                CloseActiveMdiChild();
                FormInicio inicio = new FormInicio(gestorIdioma);
                inicio.MdiParent = this;
                inicio.WindowState = FormWindowState.Maximized;
                inicio.Show();
            }
            PATENTE permisoUsuarios = new PATENTE() { IDPatente = 4 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoUsuarios, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                uSUARIOSToolStripMenuItem.Visible = false;
            }
            PATENTE permisoEventos = new PATENTE() { IDPatente = 6 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoEventos, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                eVENTOSToolStripMenuItem.Visible = false;
            }
            PATENTE permisoProductos = new PATENTE() { IDPatente = 8 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoProductos, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                pRODUCTOSToolStripMenuItem.Visible = false;
            }
            PATENTE permisoBotonIdioma = new PATENTE() { IDPatente = 2 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoBotonIdioma, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_cambiaridioma.Enabled = false;
            }
            PATENTE permisoIdioma = new PATENTE() { IDPatente = 33 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoIdioma, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                iDIOMASToolStripMenuItem.Visible = false;
            }
            PATENTE permisoEstadoTabla = new PATENTE() { IDPatente = 34 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoEstadoTabla, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                eSTADOTABLASToolStripMenuItem.Visible = false;
            }

            // Añadir manejador para el cierre del formulario
            this.FormClosing += FormPrincipal_FormClosing;
        }


        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                gestorIdioma.Quitar(this);
                if (e.CloseReason != CloseReason.ApplicationExitCall)
                {
                    nuevaBitacora = Bitacora.EventoBitacora("Usuario deslogueado por cierre de ventana");
                    gestorBitacora.RegistrarBitacora(nuevaBitacora);
                    SessionManager.LogOut();
                }
            }
            catch (Exception ex)
            {
                
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
            CloseActiveMdiChild();
            FormularioUsuarios formUsuarios = new FormularioUsuarios(gestorIdioma);
            formUsuarios.MdiParent = this;
            formUsuarios.WindowState = FormWindowState.Maximized;
            formUsuarios.Show();
        }

        private void eVENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseActiveMdiChild();
            FormEventos formInicio = new FormEventos(gestorIdioma);
            formInicio.MdiParent = this;
            formInicio.WindowState = FormWindowState.Maximized;
            formInicio.Show();
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseActiveMdiChild();
            FormProductos formProductos = new FormProductos(gestorIdioma);
            formProductos.MdiParent = this;
            formProductos.WindowState = FormWindowState.Maximized;
            formProductos.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                PATENTE permisoLogIn = new PATENTE() { IDPatente = 1 };
                if (gestorPermisos.ValidarPermisosDeUsuario(permisoLogIn, Servicios.SessionManager.Instance.UsuarioLog) == false)
                {
                    throw new Exception("El usuario no tiene permisos para iniciar sesión.");
                }
                if (SessionManager.Instance.UsuarioLog.ListaPermisos.Exists(x => x.IDPatente == 1000))
                {
                    if (gestorNegocio.VerificarIntegridadProductos() == false)
                    {
                        MessageBox.Show("La integridad de los datos ha sido comprometida. Dirijase a la ventana 'Recalcular Tablas' para ver la situacion.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        iNICIOToolStripMenuItem.Visible = false;
                        eVENTOSToolStripMenuItem.Visible = false;
                        uSUARIOSToolStripMenuItem.Visible = false;
                        pRODUCTOSToolStripMenuItem.Visible = false;
                        iDIOMASToolStripMenuItem.Visible = false;
                    }
                }
                else
                {
                    if (gestorNegocio.VerificarIntegridadProductos() == false)
                    {
                        throw new Exception("La integridad de los datos ha sido comprometida. Se cerrará la sesión.");
                    }
                }
                

                gestorIdioma.Agregar(this);

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

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PATENTE permisoInicio = new PATENTE() { IDPatente = 3 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoInicio, Servicios.SessionManager.Instance.UsuarioLog) == true)
            {
                CloseActiveMdiChild();
                FormInicio formInicio = new FormInicio(gestorIdioma);
                formInicio.MdiParent = this;
                formInicio.WindowState = FormWindowState.Maximized;
                formInicio.Show();
            }
            else
            {
                MessageBox.Show("No tiene permisos para acceder a la sección de Inicio.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Traducir(int nuevoIdioma)
        {
            TraducirAIdiomaControles(this.Controls, nuevoIdioma);
            TraducirAIdiomaMenu(this.menuStrip1.Items, nuevoIdioma);
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
        private void TraducirAIdiomaMenu(ToolStripItemCollection items, int idioma)
        {
            foreach (ToolStripItem item in items)
            {
                item.Text = gestorIdioma.ObtenerTraduccion(item.Name);
                if (item is ToolStripMenuItem menuItem && menuItem.HasDropDownItems)
                {
                    TraducirAIdiomaMenu(menuItem.DropDownItems, idioma);
                }
            }
        }

        private void LLenarComboBox(ComboBox combo, List<IDIOMA> datos)
        {
            combo.DataSource = null;
            combo.DataSource = datos;
            combo.DisplayMember = "NombreIdioma";
            combo.ValueMember = "IDIdioma";
            combo.SelectedIndex = 0;
        }

        private void button_cambiaridioma_Click(object sender, EventArgs e)
        {
            try
            {
                IDIOMA idiomaSeleccionado = comboBox_idioma.SelectedItem as IDIOMA;
                gestorIdioma.CambiarIdioma(idiomaSeleccionado.IDIdioma);
                LLenarComboBox(comboBox_idioma, gestorIdioma.ListarIdiomas());
                nuevaBitacora = Bitacora.EventoBitacora("Se cambio el Idioma");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseActiveMdiChild()
        {
            if (this.ActiveMdiChild != null)
            {
                try
                {
                    this.ActiveMdiChild.Close();
                }
                catch { }
            }
        }

        private void iDIOMASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseActiveMdiChild();
            FormIdiomas formIdioma = new FormIdiomas(gestorIdioma);
            formIdioma.MdiParent = this;
            formIdioma.WindowState = FormWindowState.Maximized;
            formIdioma.Show();
        }

        private void eSTADOTABLASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseActiveMdiChild();
            FormEstadoTablas formtablas = new FormEstadoTablas(gestorIdioma);
            formtablas.MdiParent = this;
            formtablas.WindowState = FormWindowState.Maximized;
            formtablas.Show();
        }
    }
}

