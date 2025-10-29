using BE;
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

namespace GUI
{
    public partial class FormEventos : Form, IObserver
    {
        BLL.GestionUsuarios gestorUsuarios;
        List<BE.BITACORA> bitacoraList;
        BLL.GestionIdioma gestorIdioma;
        public FormEventos(GestionIdioma IdiomasFormPrincipal)
        {
            InitializeComponent();
            gestorIdioma = IdiomasFormPrincipal;
            gestorIdioma.Agregar(this);
            Traducir(gestorIdioma.IdiomaActual);
            gestorUsuarios = new BLL.GestionUsuarios();
            bitacoraList = new List<BE.BITACORA>();
        }

        private void FormEventos_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView(dataGridView1);
            bitacoraList = gestorUsuarios.ListarBitacora();
            LlenarGrilla(dataGridView1, bitacoraList);
        }
        private void ConfigurarDataGridView(DataGridView dgv)
        {
            // Configurar el modo de selección para seleccionar filas completas
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Evitar que el usuario añada filas
            dgv.AllowUserToAddRows = false;

            // Permitir solo lectura
            dgv.ReadOnly = true;

            // Ajustar el tamaño de las columnas automáticamente
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Alternar colores en las filas
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Estilo de encabezado
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
        }

        private void LlenarGrilla(DataGridView grilla, object datos)
        {
            grilla.DataSource = null;
            grilla.DataSource = datos;
        }
        private void FormEventos_FormClosing(object sender, FormClosingEventArgs e)
        {
            gestorIdioma.Quitar(this);
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
    }
}
