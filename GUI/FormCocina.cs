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
    public partial class FormCocina : Form, IObserver
    {
        BLL.GestionIdioma gestorIdioma;
        BE.BITACORA nuevaBitacora = new BE.BITACORA();
        BLL.GestionBitacora gestorBitacora = new BLL.GestionBitacora();
        BLL.GestionPermisos gestorPermisos = new BLL.GestionPermisos();
        BLL.GestionNegocio gestorNegocio = new BLL.GestionNegocio();

         
        public FormCocina(BLL.GestionIdioma gestorIdiomaformprin)
        {
            InitializeComponent();
            gestorIdioma = gestorIdiomaformprin;
            gestorIdioma.Agregar(this);
            Traducir(gestorIdioma.IdiomaActual);
            EstiloGrilla(dataGridView1);
            EstiloGrilla(dataGridView2);        
        }

        private void FormCocina_Load(object sender, EventArgs e)
        {
            LLenarGrilla(dataGridView1, gestorNegocio.DevolverPedidoVista(gestorNegocio.ListarPedidosPagados()));
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

        private void button_verpedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    throw new Exception("Seleccionar un pedido para ver su detalle!");
                }
                PEDIDOVISTA pedidoSeleccionado = (PEDIDOVISTA)dataGridView1.CurrentRow.DataBoundItem;
                List<PRODUCTO> listaProductos = gestorNegocio.ListarProductosDePedido(pedidoSeleccionado.GetPedido());
                List<PRODUCTOVISTA> listaProductosVista = new List<PRODUCTOVISTA>();
                foreach (var producto in listaProductos)
                {
                    listaProductosVista.Add(new PRODUCTOVISTA(producto));
                }
                LLenarGrilla(dataGridView2, listaProductosVista);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_sacarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    throw new Exception("Seleccionar un pedido para marcarlo como listo!");
                }
                PEDIDOVISTA pedidoSeleccionado = (PEDIDOVISTA)dataGridView1.CurrentRow.DataBoundItem;
                if (pedidoSeleccionado.EstadoActual != ESTADO.PAGADO)
                {
                    throw new Exception("Solo se pueden marcar como listos los pedidos PAGADOS!");
                }
                gestorNegocio.PedidoListo(pedidoSeleccionado.GetPedido());
                LLenarGrilla(dataGridView1, gestorNegocio.DevolverPedidoVista(gestorNegocio.ListarPedidosPagados()));
                LLenarGrilla(dataGridView2, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
