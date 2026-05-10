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
using BLL;

namespace GUI
{
    public partial class FormPedidos : Form, IObserver
    {
        BLL.GestionIdioma gestorIdioma;
        BE.BITACORA nuevaBitacora = new BE.BITACORA();
        BLL.GestionBitacora gestorBitacora = new BLL.GestionBitacora();
        BLL.GestionPermisos gestorPermisos = new BLL.GestionPermisos();
        BLL.GestionNegocio gestorNegocio = new BLL.GestionNegocio();

        public FormPedidos(BLL.GestionIdioma gestorIdiomaformprin)
        {
            InitializeComponent();
            gestorIdioma = gestorIdiomaformprin;
            gestorIdioma.Agregar(this);
            Traducir(gestorIdioma.IdiomaActual);
            EstiloGrilla(dataGridView1);
            EstiloGrilla(dataGridView2);
            textBox_verprecio.ReadOnly = true;
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

        PEDIDO nuevoPedido;

        private void button_nuevoPedido_Click(object sender, EventArgs e)
        {
            try
            {
                nuevoPedido = null;
                nuevoPedido = new PEDIDO();
                if (textBox_nomcliente.Text == "")
                {
                    throw new Exception("LLenar el campo del nombre Cliente!");
                }
                nuevoPedido = gestorNegocio.CrearNuevoPedido(textBox_nomcliente.Text);
                LLenarGrilla(dataGridView1, nuevoPedido.Items);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            LLenarGrilla(dataGridView2, gestorNegocio.ListarProductos());
        }


        private void button_agregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedRows.Count == 0)
                {
                    throw new Exception("Seleccionar un pedido para agregar el producto!");
                }
                if (nuevoPedido == null)
                {
                    throw new Exception("Crear un nuevo pedido para agregar el producto!");
                }
                nuevoPedido.Items.Add((PRODUCTO)dataGridView2.SelectedRows[0].DataBoundItem);
                nuevoPedido.Items = gestorNegocio.AgruparProductos(nuevoPedido.Items);
                nuevoPedido = gestorNegocio.CalcularPrecioTotal(nuevoPedido);
                textBox_verprecio.Text = "$ " + nuevoPedido.PrecioTotal.ToString("C");
                LLenarGrilla(dataGridView1, nuevoPedido.Items);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_confirmarpedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (nuevoPedido == null)
                {
                    throw new Exception("Crear un nuevo pedido para confirmarlo!");
                }
                if (nuevoPedido.Items.Count == 0)
                {
                    throw new Exception("Agregar productos al pedido para confirmarlo!");
                }

                gestorNegocio.GuardarPedido(nuevoPedido);
                gestorNegocio.AgregarProductoAlPedido(nuevoPedido, nuevoPedido.Items);
                MessageBox.Show("Pedido confirmado con exito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
