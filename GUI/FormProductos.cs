using BE;
using BLL;
using Microsoft.VisualBasic;
using Servicios;
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
    public partial class FormProductos : Form, IObserver
    {
        BLL.GestionNegocio gestorNegocio;
        BLL.GestionIdioma gestorIdioma;
        BLL.GestionPermisos gestorPermisos;
        BE.BITACORA nuevaBitacora = new BITACORA();
        BLL.GestionBitacora gestorBitacora = new BLL.GestionBitacora();
        public FormProductos(BLL.GestionIdioma IdiomasFormPrincipal)
        {
            InitializeComponent();
            gestorNegocio = new BLL.GestionNegocio();
            gestorPermisos = new BLL.GestionPermisos();
            gestorIdioma = IdiomasFormPrincipal;
            gestorIdioma.Agregar(this);
            Traducir(gestorIdioma.IdiomaActual);
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            // Configurar el DataGridView
            ConfigurarDataGridView(dataGridView1);
            ConfigurarDataGridView(dataGridView2);

            // Llenar los controles con datos
            LLenarGrilla(dataGridView1, gestorNegocio.ListarProductos());
            LLenarComboBox(comboBox1, gestorNegocio.ListarTipoProducto());
            PATENTE permisoAgregarProducto = new PATENTE() { IDPatente = 9 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoAgregarProducto, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_agregarprod.Enabled = false;
            }
            PATENTE permisoBorrarProd = new PATENTE() { IDPatente = 10 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoBorrarProd, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_borrarprod.Enabled = false;
            }
            PATENTE permisoModificarProd = new PATENTE() { IDPatente = 11 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoModificarProd, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_modificarprod.Enabled = false;
            }
            PATENTE permisoVerHistorico = new PATENTE() { IDPatente = 12 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoVerHistorico, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_verhistprod.Enabled = false;
            }
            PATENTE permisoVolverProd = new PATENTE() { IDPatente = 21 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoVolverProd, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_volverproducto.Enabled = false;
            }
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

            dgv.MultiSelect = false;
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
                    if (!string.IsNullOrEmpty(textBox_precioproducto.Text) && decimal.TryParse(textBox_precioproducto.Text, out decimal precio) && precio >= 0)
                    {
                        nuevoProducto.PrecioUnitario = precio;
                    }
                    else
                    {
                        throw new Exception("El precio debe ser un valor numérico positivo.");
                    }
                    gestorNegocio.AgregarProducto(nuevoProducto);
                    LLenarGrilla(dataGridView1, gestorNegocio.ListarProductos());
                    nuevaBitacora = Bitacora.EventoBitacora("Se agrego un producto nuevo.");
                    gestorBitacora.RegistrarBitacora(nuevaBitacora);
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

        private void formProductos_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button_borrarprod_Click(object sender, EventArgs e)
        {
            try
            {
                BE.PRODUCTO productoSeleccionado = dataGridView1.SelectedRows[0].DataBoundItem as BE.PRODUCTO;
                gestorNegocio.BorrarProducto(productoSeleccionado);
                LLenarGrilla(dataGridView1, gestorNegocio.ListarProductos());
                nuevaBitacora = Bitacora.EventoBitacora("Se borro un producto.");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_modificarprod_Click(object sender, EventArgs e)
        {
            try
            {
                BE.PRODUCTO productoSeleccionado = dataGridView1.SelectedRows[0].DataBoundItem as BE.PRODUCTO;
                BE.PRODUCTO productoModificado = new BE.PRODUCTO();
                productoModificado.IDProducto = productoSeleccionado.IDProducto;
                productoModificado.NombreProducto = Interaction.InputBox("Ingrese el nuevo nombre del producto:", "Modificar Producto", productoSeleccionado.NombreProducto);
                productoModificado.TipoProducto = productoSeleccionado.TipoProducto; // Mantener el mismo tipo por simplicidad
                string precioInput = Interaction.InputBox("Ingrese el nuevo precio del producto:", "Modificar Producto", productoSeleccionado.PrecioUnitario.ToString());
                if (decimal.TryParse(precioInput, out decimal nuevoPrecio) && nuevoPrecio >= 0)
                {
                    productoModificado.PrecioUnitario = nuevoPrecio;
                }
                else
                {
                    throw new Exception("El precio debe ser un valor numérico positivo.");
                }
                gestorNegocio.ModificarProducto(productoSeleccionado, productoModificado);
                LLenarGrilla(dataGridView1, gestorNegocio.ListarProductos());
                nuevaBitacora = Bitacora.EventoBitacora("Se modifico un producto.");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_verhistprod_Click(object sender, EventArgs e)
        {
            try
            {
                LLenarGrilla(dataGridView2, gestorNegocio.ListarHistoricoProducto(dataGridView1.SelectedRows[0].DataBoundItem as BE.PRODUCTO));
                nuevaBitacora = Bitacora.EventoBitacora("Se solicito ver el historial del producto.");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_volverproducto_Click(object sender, EventArgs e)
        {
            try
            {
                BE.PRODUCTO productoSeleccionado = dataGridView2.SelectedRows[0].DataBoundItem as BE.PRODUCTO;
                BE.PRODUCTO productoAModificar = new BE.PRODUCTO();
                List<BE.PRODUCTO> listaprod = new List<PRODUCTO>();
                listaprod = gestorNegocio.ListarProductos();
                productoAModificar = listaprod.Find(p => p.IDProducto == productoSeleccionado.IDProducto);
                if(productoAModificar == null) { throw new Exception("No se encontró el producto actual para modificar."); }
                gestorNegocio.ModificarProducto(productoAModificar,productoSeleccionado);
                LLenarGrilla(dataGridView1, gestorNegocio.ListarProductos());
                LLenarGrilla(dataGridView2, gestorNegocio.ListarHistoricoProducto(productoSeleccionado));
                nuevaBitacora = Bitacora.EventoBitacora("Se volvio el producto al estado indicado");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
