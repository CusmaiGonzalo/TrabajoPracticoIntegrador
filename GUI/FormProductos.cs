using Microsoft.VisualBasic;
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
    public partial class FormProductos : Form
    {
        BLL.GestionNegocio gestorNegocio;
        public FormProductos()
        {
            InitializeComponent();
            gestorNegocio = new BLL.GestionNegocio();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            LLenarGrilla(dataGridView1, gestorNegocio.ListarProductos());
        }

        private void LLenarGrilla(DataGridView grilla, object datos)
        {
            grilla.DataSource = null;
            grilla.DataSource = datos;
        }

        private void button_agregarprod_Click(object sender, EventArgs e)
        {
            try
            {
                BE.PRODUCTO nuevoProducto = new BE.PRODUCTO();
                nuevoProducto.NombreProducto = Interaction.InputBox("Ingrese el nombre del producto:", "Agregar Producto", "Sin especificar...");
                nuevoProducto.TipoProducto = Interaction.InputBox("Ingrese el tipo de producto:", "Agregar Producto", "Sin especificar...");
                string precioInput = Interaction.InputBox("Ingrese el precio unitario del producto:", "Agregar Producto", "0.00");
                if (decimal.TryParse(precioInput, out decimal precioUnitario) && decimal.Parse(precioInput) < 0)
                {
                    nuevoProducto.PrecioUnitario = precioUnitario;
                }
                else
                {
                    throw new Exception("Precio unitario inválido.");
                }
                gestorNegocio.AgregarProducto(nuevoProducto);
                LLenarGrilla(dataGridView1, gestorNegocio.ListarProductos());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
