using BE;
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
        public FormEstadoTablas(BLL.GestionIdioma gestorIdiomaformprin)
        {
            InitializeComponent();
            gestorNegocio = new BLL.GestionNegocio();
            gestorIdioma = gestorIdiomaformprin;
            gestorIdioma.Agregar(this);
            Traducir(gestorIdioma.IdiomaActual);
            EstiloGrilla(dataGridView1);
            textBox1.Enabled = false;
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
