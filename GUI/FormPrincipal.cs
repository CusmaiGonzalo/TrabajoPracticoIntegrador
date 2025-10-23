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
            AbrirFormulario<FormInicio>();

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
                if (gestorNegocio.VerificarIntegridadProductos() == false)
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

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FormInicio>();
        }

        // Método que obtiene los nombres (Name) de todos los Label, Button y elementos de menú
        // de todos los formularios del ensamblado GUI excepto la clase Form1.
        public List<string> ObtenerNombresControlesDesigner()
        {
            List<string> nombres = new List<string>();
            var asm = this.GetType().Assembly; // ensamblado actual (GUI)
            var formTypes = asm.GetTypes().Where(t => t.IsSubclassOf(typeof(Form)) && t.Name != "Form1");

            foreach (var ft in formTypes)
            {
                try
                {
                    // Intentar crear una instancia si tiene constructor sin parámetros
                    object? instance = null;
                    try
                    {
                        instance = Activator.CreateInstance(ft);
                    }
                    catch
                    {
                        // No se puede instanciar, saltar
                        continue;
                    }

                    if (instance is Form formInstance)
                    {
                        // Recorrer controles del formulario
                        CollectControlNames(formInstance.Controls, nombres);

                        // Buscar ToolStrip/MenuStrip/ToolStripMenuItem en componentes (si existen)
                        foreach (var comp in GetComponentsOfType<ToolStrip>(formInstance))
                        {
                            if (comp is MenuStrip menu)
                            {
                                foreach (ToolStripItem item in menu.Items)
                                {
                                    CollectToolStripItemNames(item, nombres);
                                }
                            }
                            else if (comp is ToolStrip tool)
                            {
                                foreach (ToolStripItem item in tool.Items)
                                {
                                    CollectToolStripItemNames(item, nombres);
                                }
                            }
                        }

                        formInstance.Dispose();
                    }
                }
                catch
                {
                    // Ignorar tipos problemáticos
                    continue;
                }
            }

            // Devolver nombres únicos
            return nombres.Distinct().ToList();
        }

        // Recorre recursivamente una colección de controles y agrega nombres de Label y Button
        private void CollectControlNames(Control.ControlCollection controls, List<string> nombres)
        {
            foreach (Control ctrl in controls)
            {
                try
                {
                    if (!string.IsNullOrEmpty(ctrl.Name) && (ctrl is Label || ctrl is Button))
                    {
                        nombres.Add(ctrl.Name);
                    }

                    // Si el control es un ToolStrip (contenedor de ToolStripItems), procesar sus ítems
                    if (ctrl is ToolStrip strip)
                    {
                        foreach (ToolStripItem item in strip.Items)
                        {
                            CollectToolStripItemNames(item, nombres);
                        }
                    }

                    // Recursividad para contenedores
                    if (ctrl.HasChildren)
                    {
                        CollectControlNames(ctrl.Controls, nombres);
                    }
                }
                catch
                {
                    // ignorar controles problemáticos
                }
            }
        }

        // Recorre recursivamente ToolStripItem y sus DropDownItems para obtener nombres
        private void CollectToolStripItemNames(ToolStripItem item, List<string> nombres)
        {
            if (item == null) return;
            try
            {
                if (!string.IsNullOrEmpty(item.Name))
                {
                    nombres.Add(item.Name);
                }

                if (item is ToolStripMenuItem menuItem)
                {
                    foreach (ToolStripItem sub in menuItem.DropDownItems)
                    {
                        CollectToolStripItemNames(sub, nombres);
                    }
                }
            }
            catch
            {
                // ignorar
            }
        }

        // Obtener componentes de un tipo concreto desde un Form (incluye campos privados como menuStrip1)
        private IEnumerable<T> GetComponentsOfType<T>(Form form) where T : Component
        {
            List<T> results = new List<T>();
            // Buscar en controles directamente
            foreach (Control c in form.Controls)
            {
                if (c is T t) results.Add(t);
            }

            // Intentar obtener campos privados del formulario que sean del tipo T (por ejemplo menuStrip1)
            var fields = form.GetType().GetFields(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
            foreach (var f in fields)
            {
                try
                {
                    if (typeof(T).IsAssignableFrom(f.FieldType))
                    {
                        var val = f.GetValue(form) as T;
                        if (val != null) results.Add(val);
                    }
                }
                catch { }
            }

            return results;
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
