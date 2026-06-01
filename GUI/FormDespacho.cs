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
    public partial class FormDespacho : Form, IObserver
    {
        BLL.GestionIdioma gestorIdioma;
        BE.BITACORA nuevaBitacora = new BE.BITACORA();
        BLL.GestionBitacora gestorBitacora = new BLL.GestionBitacora();
        BLL.GestionPermisos gestorPermisos = new BLL.GestionPermisos();
        BLL.GestionNegocio gestorNegocio = new BLL.GestionNegocio();

        public FormDespacho(BLL.GestionIdioma gestorIdiomaformprin)
        {
            InitializeComponent();
            gestorIdioma = gestorIdiomaformprin;
            gestorIdioma.Agregar(this);
            Traducir(gestorIdioma.IdiomaActual);
            EstiloGrilla(dataGridView1);
        }

        private void FormDespacho_Load(object sender, EventArgs e)
        {
            LLenarGrilla(dataGridView1, gestorNegocio.DevolverPedidoVista(gestorNegocio.ListarPedidosListos()));
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
            grilla.AutoGenerateColumns = true;
        }

        private void button_entregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.SelectedRows.Count == 0)
                {
                    throw new Exception("Seleccionar un pedido para marcarlo como entregado!");
                }
                PEDIDOVISTA pedidoSeleccionado = (PEDIDOVISTA)dataGridView1.CurrentRow.DataBoundItem;
                gestorNegocio.ActualizarEstadoPedido(pedidoSeleccionado.GetPedido(), ESTADO.ENTREGADO);
                MessageBox.Show("Pedido marcado como entregado!");
                LLenarGrilla(dataGridView1, gestorNegocio.DevolverPedidoVista(gestorNegocio.ListarPedidosListos()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
