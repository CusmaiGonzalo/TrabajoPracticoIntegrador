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
    public partial class FormSupervisor : Form, IObserver
    {
        BLL.GestionIdioma gestorIdioma;
        BE.BITACORA nuevaBitacora = new BE.BITACORA();
        BLL.GestionBitacora gestorBitacora = new BLL.GestionBitacora();
        BLL.GestionPermisos gestorPermisos = new BLL.GestionPermisos();
        BLL.GestionNegocio gestorNegocio = new BLL.GestionNegocio();
        public FormSupervisor(BLL.GestionIdioma gestorIdiomaformprin)
        {
            InitializeComponent();
            gestorIdioma = gestorIdiomaformprin;
            gestorIdioma.Agregar(this);
            Traducir(gestorIdioma.IdiomaActual);
            EstiloGrilla(dataGridView1);
        }

        private void FormSupervisor_Load(object sender, EventArgs e)
        {
            LLenarComboBox();
            LLenarGrilla(dataGridView1, gestorNegocio.DevolverPedidoVista(gestorNegocio.ListarPedidos()));
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
        private void LLenarComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("TODOS");
            comboBox1.Items.Add("PAGADO");
            comboBox1.Items.Add("COCINA");
            comboBox1.Items.Add("LISTO");
            comboBox1.Items.Add("ENTREGADO");
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button_aplicarfiltro_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex.ToString())
                {
                    case "0":
                        LLenarGrilla(dataGridView1, gestorNegocio.DevolverPedidoVista(gestorNegocio.ListarPedidos()));
                        break;
                    case "1":
                        LLenarGrilla(dataGridView1, gestorNegocio.DevolverPedidoVista(gestorNegocio.ListarPedidosPagados()));
                        break;
                    case "2":
                        LLenarGrilla(dataGridView1, gestorNegocio.DevolverPedidoVista(gestorNegocio.ListarPedidosCocina()));
                        break;
                    case "3":
                        LLenarGrilla(dataGridView1, gestorNegocio.DevolverPedidoVista(gestorNegocio.ListarPedidosListos()));
                        break;
                    case "4":
                        LLenarGrilla(dataGridView1, gestorNegocio.DevolverPedidoVista(gestorNegocio.ListarPedidosEntregados()));
                        break;
                    default:
                        LLenarGrilla(dataGridView1, gestorNegocio.DevolverPedidoVista(gestorNegocio.ListarPedidos()));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_devolvercocina_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.SelectedRows.Count > 0)
                {
                    BE.PEDIDOVISTA pedidoSeleccionado = (BE.PEDIDOVISTA)dataGridView1.SelectedRows[0].DataBoundItem;
                    if (pedidoSeleccionado.GetPedido().EstadoActual == ESTADO.ENTREGADO || pedidoSeleccionado.GetPedido().EstadoActual == ESTADO.LISTO)
                    {
                        gestorNegocio.ActualizarEstadoPedido(pedidoSeleccionado.GetPedido(), ESTADO.COCINA);
                        LLenarGrilla(dataGridView1, gestorNegocio.DevolverPedidoVista(gestorNegocio.ListarPedidos()));
                    }
                    else
                    {
                        MessageBox.Show("Solo se pueden devolver a cocina los pedidos que estén en estado 'ENTREGADO' o 'LISTO'.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un pedido para devolver a cocina.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
