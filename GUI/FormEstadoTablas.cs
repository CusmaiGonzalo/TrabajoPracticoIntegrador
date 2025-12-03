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
    public partial class FormEstadoTablas : Form, IObserver
    {
        BLL.GestionNegocio gestorNegocio;
        BLL.GestionIdioma gestorIdioma;
        BE.BITACORA nuevaBitacora = new BITACORA();
        BLL.GestionBitacora gestorBitacora = new BLL.GestionBitacora();
        BLL.GestionPermisos gestorPermisos = new BLL.GestionPermisos();
        public FormEstadoTablas(BLL.GestionIdioma gestorIdiomaformprin)
        {
            InitializeComponent();
            gestorNegocio = new BLL.GestionNegocio();
            gestorIdioma = gestorIdiomaformprin;
            gestorIdioma.Agregar(this);
            Traducir(gestorIdioma.IdiomaActual);
            EstiloGrilla(dataGridView1);
            textBox1.Enabled = false;
            PATENTE permisoEstTabla = new PATENTE() { IDPatente = 13 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoEstTabla, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_recalctabla.Enabled = false;
            }
        }
        private void LLenarGrilla(DataGridView grilla, object obj)
        {
            grilla.DataSource = null;
            grilla.DataSource = obj;
        }
        private void EstiloGrilla(DataGridView grilla)
        {
            grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grilla.MultiSelect = false;
            grilla.AllowUserToAddRows = false;
            grilla.ReadOnly = true;
            grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grilla.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            grilla.ColumnHeadersDefaultCellStyle.Font = new Font(grilla.Font, FontStyle.Bold);
        }

        private void FormEstadoTablas_Load(object sender, EventArgs e)
        {
            LLenarGrilla(dataGridView1, gestorNegocio.ListarDVHs());
            textBox1.Text = gestorNegocio.EstadoDeTabla();

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

        private void button_recalctabla_Click(object sender, EventArgs e)
        {
            try
            {

                gestorNegocio.RepararIntegridadProductos();
                if (MessageBox.Show("Se recalcularan los datos de las tablas. \nDesea confirmar?", "ESTADO TABLAS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    LLenarGrilla(dataGridView1, gestorNegocio.ListarDVHs());
                    textBox1.Text = gestorNegocio.EstadoDeTabla();
                    nuevaBitacora = Bitacora.EventoBitacora("Se reparo la integridad recalculando las tablas.");
                    gestorBitacora.RegistrarBitacora(nuevaBitacora);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_realizarbackup_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog1.Description = "Seleccione la carpeta donde desea guardar el Backup";
                folderBrowserDialog1.ShowNewFolderButton = false;
                folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;

                string rutaSeleccionada = "";
                string nombre = "TPIntegrador";
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    rutaSeleccionada = folderBrowserDialog1.SelectedPath;
                    gestorNegocio.RealizarBackup(rutaSeleccionada, nombre);
                    MessageBox.Show("Backup realizado con exito en la ruta: " + rutaSeleccionada, "BACKUP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("No se selecciono ninguna ruta para guardar el Backup.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_realizarrestore_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Seleccione el archivo de Backup a restaurar";
                openFileDialog1.Filter = "Archivos de Backup (*.bak)|*.bak";

                string rutaSeleccionada = "";
                string nombre = "TPIntegrador";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rutaSeleccionada = openFileDialog1.FileName;
                    gestorNegocio.RestaurarBackup(rutaSeleccionada, nombre);
                    
                    
                    nuevaBitacora = Bitacora.EventoBitacora($"Restore realizado desde la ruta: {rutaSeleccionada}");
                    gestorBitacora.RegistrarBitacora(nuevaBitacora);
                    
                    MessageBox.Show("Restore realizado con éxito desde la ruta: " + rutaSeleccionada + "\n\nLa sesión se cerrará para aplicar los cambios.", "RESTORE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    SessionManager.LogOut();
                    Application.OpenForms.OfType<FormPrincipal>().FirstOrDefault()?.Close();
                }
                else
                {
                    throw new Exception("No se seleccionó ningún archivo de Backup para restaurar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
