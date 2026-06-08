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
using Microsoft.VisualBasic;

namespace GUI
{
    public partial class FormPedidos : Form, IObserver
    {
        BLL.GestionIdioma gestorIdioma;
        BE.BITACORA nuevaBitacora = new BE.BITACORA();
        BLL.GestionBitacora gestorBitacora = new BLL.GestionBitacora();
        BLL.GestionPermisos gestorPermisos = new BLL.GestionPermisos();
        BLL.GestionNegocio gestorNegocio = new BLL.GestionNegocio();
        List<BE.PRODUCTOVISTA> productosVista;

        public FormPedidos(BLL.GestionIdioma gestorIdiomaformprin)
        {
            InitializeComponent();
            gestorIdioma = gestorIdiomaformprin;
            gestorIdioma.Agregar(this);
            Traducir(gestorIdioma.IdiomaActual);
            EstiloGrilla(dataGridView1);
            EstiloGrilla(dataGridView2);
            textBox_verprecio.ReadOnly = true;
            textBox_descuento.ReadOnly = true;
            textBox_preciofinal.ReadOnly = true;
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
                productosVista = null;
                productosVista = new List<PRODUCTOVISTA>();
                if (textBox_nomcliente.Text == "")
                {
                    throw new Exception("LLenar el campo del nombre Cliente!");
                }
                nuevoPedido.EstadoActual = ESTADO.INICIADO;
                nuevoPedido = gestorNegocio.CrearNuevoPedido(textBox_nomcliente.Text);
                LLenarGrilla(dataGridView2, nuevoPedido.Items);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            LLenarGrilla(dataGridView1, gestorNegocio.ListarProductos());
        }


        private void button_agregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    throw new Exception("Seleccionar un pedido para agregar el producto!");
                }
                if (nuevoPedido == null)
                {
                    throw new Exception("Crear un nuevo pedido para agregar el producto!");
                }
                if (nuevoPedido.EstadoActual != ESTADO.INICIADO)
                {
                    throw new Exception("Solo se pueden agregar productos a pedidos INICIADOS!");
                }
                nuevoPedido.Items.Add((PRODUCTO)dataGridView1.SelectedRows[0].DataBoundItem);
                nuevoPedido.Items = gestorNegocio.AgruparProductos(nuevoPedido.Items);
                nuevoPedido = gestorNegocio.CalcularPrecioTotal(nuevoPedido);
                textBox_verprecio.Text = "$ " + nuevoPedido.PrecioTotal.ToString("C");

                // Limpiar la lista antes de llenarla para evitar duplicados
                LimpiarLista(productosVista);

                foreach (PRODUCTO item in nuevoPedido.Items)
                {
                    BE.PRODUCTOVISTA nuevoprod = new BE.PRODUCTOVISTA(item);
                    productosVista.Add(nuevoprod);
                }
                LLenarGrilla(dataGridView2, productosVista);
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
                if (nuevoPedido.EstadoActual != ESTADO.CALCULADO)
                {
                    throw new Exception("El pedido debe tener el precio calculado para ser confirmado!");
                }
                if (Interaction.MsgBox("El precio final del pedido es: $ " + nuevoPedido.PrecioTotal.ToString("C") + ". Confirmar el pedido para proceder al pago.", MsgBoxStyle.OkCancel, "Confirmar Pedido") == MsgBoxResult.Cancel)
                {
                    throw new Exception("Pedido no Pagado!");
                }
                nuevoPedido.EstadoActual = ESTADO.PAGADO;
                gestorNegocio.GuardarPedido(nuevoPedido);
                gestorNegocio.AgregarProductoAlPedido(nuevoPedido, nuevoPedido.Items);
                MessageBox.Show("Pedido confirmado con exito!");
                LLenarGrilla(dataGridView1, gestorNegocio.ListarProductos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarLista(List<PRODUCTOVISTA> lista)
        {
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                lista.RemoveAt(i);
            }
        }

        private void button_aplicarDescuento_Click(object sender, EventArgs e)
        {
            try
            {
                if (nuevoPedido == null)
                {
                    throw new Exception("Crear un nuevo pedido para aplicar el descuento!");
                }
                if (nuevoPedido.Items.Count == 0)
                {
                    throw new Exception("Agregar productos al pedido para aplicar el descuento!");
                }
                if (nuevoPedido.EstadoActual != ESTADO.INICIADO)
                {
                    throw new Exception("El descuento solo se puede aplicar a pedidos INICIADOS!");
                }
                string descuento = Interaction.InputBox("Ingrese el porcentaje de descuento a aplicar. Debe ser un valor entre 0 y 100", "Aplicar Descuento", "0");
                if (!decimal.TryParse(descuento, out decimal porcentajeDescuento))
                {
                    throw new Exception("Ingrese un valor numérico válido para el descuento!");
                }
                if (porcentajeDescuento < 0 || porcentajeDescuento > 100)
                {
                    throw new Exception("Ingrese un porcentaje de descuento entre 0 y 100!");
                }
                textBox_descuento.Text = descuento + " %";
                nuevoPedido = gestorNegocio.AplicarDescuento(nuevoPedido, porcentajeDescuento);
                textBox_preciofinal.Text = "$ " + nuevoPedido.PrecioTotal.ToString("C");
                nuevoPedido.EstadoActual = ESTADO.CALCULADO;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
