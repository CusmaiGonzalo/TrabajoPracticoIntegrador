﻿using BE;
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
        
        public FormPrincipal()
        {
            InitializeComponent();
            
            LLenarComboBox(comboBox_idioma, gestorIdioma.ListarIdiomas());

            // Abrir FormInicio al iniciar el FormPrincipal (usando el constructor que recibe GestionIdioma)
            CloseActiveMdiChild();
            FormInicio inicio = new FormInicio(gestorIdioma);
            inicio.MdiParent = this;
            inicio.WindowState = FormWindowState.Maximized;
            inicio.Show();

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
                if (gestorNegocio.VerificarIntegridadProductos() == false)
                {
                    throw new Exception("La integridad de los datos ha sido comprometida. Se cerrará la sesión.");
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
            FormInicio formInicio = new FormInicio(gestorIdioma);
            formInicio.MdiParent = this;
            formInicio.WindowState = FormWindowState.Maximized;
            formInicio.Show();
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
            foreach(ToolStripItem item in items)
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
    }
}

