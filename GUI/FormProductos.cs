using BE;
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
            // Configurar el DataGridView
            ConfigurarDataGridView(dataGridView1);
            
            // Llenar los controles con datos
            LLenarGrilla(dataGridView1, gestorNegocio.ListarProductos());
            LLenarComboBox(comboBox1, gestorNegocio.ListarTipoProducto());
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

        private void LLenarGrilla(DataGridView grilla, object datos)
        {
            grilla.DataSource = null;
            grilla.DataSource = datos;
        }
        private void LLenarComboBox(ComboBox combo, List<TIPO_PRODUCTO> datos)
        {
            combo.DataSource = null;
            combo.DataSource = datos;
            combo.DisplayMember = "Tipo";
            combo.ValueMember = "IDTipo";       
        }

        private void button_agregarprod_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (textBox_nombreproducto.Text != "" || textBox_precioproducto.Text != "")
                {
                    BE.PRODUCTO nuevoProducto = new BE.PRODUCTO();
                    nuevoProducto.NombreProducto = textBox_nombreproducto.Text;
                    // Obtener el objeto TIPO_PRODUCTO seleccionado y su IDTipo
                    if (comboBox1.SelectedItem is BE.TIPO_PRODUCTO tipoSeleccionado)
                    {
                        nuevoProducto.TipoProducto = tipoSeleccionado.IDTipo.ToString();
                    }
                    if(!string.IsNullOrEmpty(textBox_precioproducto.Text) && decimal.TryParse(textBox_precioproducto.Text, out decimal precio) && precio >= 0)
                    {
                        nuevoProducto.PrecioUnitario = precio;
                    }
                    else
                    {
                        throw new Exception("El precio debe ser un valor numérico positivo.");
                    }
                    gestorNegocio.AgregarProducto(nuevoProducto);
                    LLenarGrilla(dataGridView1, gestorNegocio.ListarProductos());
                }
                else
                {
                    throw new Exception("Ingrese los datos correctamente...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
