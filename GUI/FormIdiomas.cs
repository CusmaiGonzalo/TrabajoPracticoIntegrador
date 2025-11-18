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
using Microsoft.VisualBasic;

namespace GUI
{
    public partial class FormIdiomas : Form, IObserver
    {
        BLL.GestionIdioma gestorIdiomas;
        IDIOMA idiomaseleccionado;
        public FormIdiomas(BLL.GestionIdioma idiomasFormPrincipal)
        {
            InitializeComponent();
            gestorIdiomas = idiomasFormPrincipal;
            gestorIdiomas.Agregar(this);
            Traducir(gestorIdiomas.IdiomaActual);
            EstiloGrilla(dataGridView1);
            textBox_idiomaselec.Enabled = false;
            idiomaseleccionado = new IDIOMA();
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
            LLenarComboBox(comboBox1, gestorIdiomas.ListarTodosLosIdiomas());
            idiomaseleccionado = null;
        }

        private void button_selIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                idiomaseleccionado = null;
                idiomaseleccionado = (IDIOMA)comboBox1.SelectedItem;
                LLenarGrilla(dataGridView1, gestorIdiomas.ListarTraduccionesYEtiquetas(idiomaseleccionado.IDIdioma));
                textBox_idiomaselec.Text = idiomaseleccionado.NombreIdioma + " Estado: ";
                if (idiomaseleccionado.Alta == 1)
                {
                    textBox_idiomaselec.Text += "ACTIVO";
                }
                else
                {
                    textBox_idiomaselec.Text += "INACTIVO";
                }
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
                if (textBox1.Text == "") { throw new Exception("Completar con el nombre del idioma nuevo."); }
                List<TRADUCCION> listaetiquetas = new List<TRADUCCION>();
                listaetiquetas = gestorIdiomas.ListarTraduccionesYEtiquetas(1); //tomar las etiquetas del idioma por defecto (1)
                foreach (TRADUCCION etiqueta in listaetiquetas)
                {
                    etiqueta.Traduccion = "[" + etiqueta.TraduccionEspañol + "]";
                }
                gestorIdiomas.InsertarIdiomaNuevo(textBox1.Text, listaetiquetas);
                LLenarComboBox(comboBox1, gestorIdiomas.ListarTodosLosIdiomas());
                MessageBox.Show("Idioma agregado correctamente.", "IDIOMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_modtrad_Click(object sender, EventArgs e)
        {
            try
            {
                if (idiomaseleccionado == null) { throw new Exception("Seleccione un idioma."); }
                TRADUCCION tradseleccionada = (TRADUCCION)dataGridView1.SelectedRows[0].DataBoundItem;
                tradseleccionada.Traduccion = Interaction.InputBox("Ingresar nueva traducción:", "TRADUCCION", $"{tradseleccionada.Traduccion}");
                gestorIdiomas.ModificarTraduccion(tradseleccionada);
                MessageBox.Show("Traducción modificada correctamente.", "IDIOMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LLenarGrilla(dataGridView1, gestorIdiomas.ListarTraduccionesYEtiquetas(idiomaseleccionado.IDIdioma));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_altaidi_Click(object sender, EventArgs e)
        {
            try
            {
                if (idiomaseleccionado == null) { throw new Exception("Seleccione un idioma."); }
                gestorIdiomas.AltaIdioma(idiomaseleccionado);
                idiomaseleccionado.Alta = 1;
                MessageBox.Show("Idioma dado de ALTA correctamente.", "IDIOMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_idiomaselec.Text = idiomaseleccionado.NombreIdioma + " Estado: ACTIVO";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_borraridioma_Click(object sender, EventArgs e)
        {
            try
            {
                if (idiomaseleccionado == null) { throw new Exception("Seleccione un idioma."); }
                gestorIdiomas.BorrarIdioma(idiomaseleccionado);
                idiomaseleccionado = null;
                LLenarGrilla(dataGridView1, null);
                LLenarComboBox(comboBox1, gestorIdiomas.ListarTodosLosIdiomas());
                MessageBox.Show("Idioma se borro correctamente.", "IDIOMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_idiomaselec.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_bajaidioma_Click(object sender, EventArgs e)
        {
            try
            {
                if (idiomaseleccionado == null) { throw new Exception("Seleccione un idioma."); }
                gestorIdiomas.BajaIdioma(idiomaseleccionado);
                idiomaseleccionado.Alta = 0;
                MessageBox.Show("Idioma dado de BAJA correctamente.", "IDIOMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_idiomaselec.Text = idiomaseleccionado.NombreIdioma + " Estado: INACTIVO";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_modnomid_Click(object sender, EventArgs e)
        {
            try
            {
                if(idiomaseleccionado == null) { throw new Exception("Seleccione un idioma."); }
                idiomaseleccionado.NombreIdioma = Interaction.InputBox("Ingresar nuevo nombre del idioma:", "IDIOMA", $"{idiomaseleccionado.NombreIdioma}");
                gestorIdiomas.ModificarNombreDelIdioma(idiomaseleccionado);
                MessageBox.Show("Nombre del idioma modificado correctamente.", "IDIOMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LLenarComboBox(comboBox1, gestorIdiomas.ListarTodosLosIdiomas());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
