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
using BE;

namespace GUI
{
    public partial class FormIdiomas : Form, IObserver
    {
        BLL.GestionIdioma gestorIdiomas;
        public FormIdiomas(BLL.GestionIdioma gi)
        {
            InitializeComponent();
            this.gestorIdiomas = gi;
            gestorIdiomas.Agregar(this);
            EstiloGrilla(dataGridView1);
        }
        public void Traducir(int nuevoIdioma)
        {
            TraducirAIdiomaControles(this.Controls, nuevoIdioma);
        }
        private void TraducirAIdiomaControles(Control.ControlCollection controles, int idioma)
        {
            foreach (Control control in controles)
            {
                control.Text = gestorIdiomas.ObtenerTraduccion(control.Name);
                if (control.HasChildren)
                {
                    TraducirAIdiomaControles(control.Controls, idioma);
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
        private void LLenarGrilla(DataGridView grilla, object datos)
        {
            grilla.DataSource = null;
            grilla.DataSource = datos;
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
        private void FormIdiomas_Load(object sender, EventArgs e)
        {
            LLenarComboBox(comboBox1, gestorIdiomas.ListarIdiomas());

        }

        private void button_selIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                IDIOMA idiomaseleccionado = new IDIOMA();
                idiomaseleccionado = (IDIOMA)comboBox1.SelectedItem;
                LLenarGrilla(dataGridView1, gestorIdiomas.ListarTraduccionesYEtiquetas(idiomaseleccionado.IDIdioma));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_agregaridioma_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text == "") { throw new Exception("Completar con el nombre del idioma nuevo."); }
                List<TRADUCCION> listaetiquetas = new List<TRADUCCION>();
                listaetiquetas = gestorIdiomas.ListarTraduccionesYEtiquetas(1); //tomar las etiquetas del idioma por defecto (1)
                foreach (TRADUCCION etiqueta in listaetiquetas)
                {
                    etiqueta.Traduccion = "[" + etiqueta.TraduccionEspañol + "]";
                }
                gestorIdiomas.InsertarIdiomaNuevo(textBox1.Text, listaetiquetas);
                LLenarComboBox(comboBox1, gestorIdiomas.ListarIdiomas());
                MessageBox.Show("Idioma agregado correctamente.", "IDIOMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
