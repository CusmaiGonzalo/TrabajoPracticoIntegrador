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
        BLL.GestionPermisos gestorPermisos;
        public FormEventos(GestionIdioma IdiomasFormPrincipal)
        {
            InitializeComponent();
            gestorIdioma = IdiomasFormPrincipal;
            gestorPermisos = new BLL.GestionPermisos();
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
            PATENTE permisoVerGrilla = new PATENTE() { IDPatente = 7 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoVerGrilla, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                dataGridView1.Visible = false;
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

        private void button_aplicarfiltro_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkBox_error.Checked && !checkBox_tipo.Checked)
                {
                    LlenarGrilla(dataGridView1, bitacoraList);
                    return;
                }
                if (checkBox_error.Checked && checkBox_tipo.Checked)
                {
                    LlenarGrilla(dataGridView1, bitacoraList);
                    return;
                }
                if (checkBox_tipo.Checked)
                {
                    List<BE.BITACORA> bitacoraFiltrada = new List<BITACORA>();
                    bitacoraFiltrada = bitacoraList.Where(b => b.Tipo == "EVENTO").ToList();
                    LlenarGrilla(dataGridView1, bitacoraFiltrada);
                }
                if (checkBox_error.Checked)
                {
                    List<BE.BITACORA> bitacoraFiltrada = new List<BITACORA>();
                    bitacoraFiltrada = bitacoraList.Where(b => b.Tipo == "ERROR").ToList();
                    LlenarGrilla(dataGridView1, bitacoraFiltrada);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_filtrarSistema_Click(object sender, EventArgs e)
        {
            if (!checkBox_sistema.Checked && !checkBox_usuario.Checked)
            {
                LlenarGrilla(dataGridView1, bitacoraList);
                return;
            }
            if (checkBox_sistema.Checked && checkBox_usuario.Checked)
            {
                LlenarGrilla(dataGridView1, bitacoraList);
                return;
            }
            if (checkBox_sistema.Checked)
            {
                List<BE.BITACORA> bitacoraFiltrada = new List<BITACORA>();
                bitacoraFiltrada = bitacoraList.Where(b => b.UserBitacora == "SISTEMA").ToList();
                LlenarGrilla(dataGridView1, bitacoraFiltrada);
            }
            if (checkBox_usuario.Checked)
            {
                List<BE.BITACORA> bitacoraFiltrada = new List<BITACORA>();
                bitacoraFiltrada = bitacoraList.Where(b => b.UserBitacora != "SISTEMA").ToList();
                LlenarGrilla(dataGridView1, bitacoraFiltrada);
            }
        }

        private void button_filtrofecha_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker_desde.Value > dateTimePicker_hasta.Value)
                {
                    throw new Exception("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.");
                }
                List<BE.BITACORA> bitacoraFiltrada = new List<BITACORA>();
                bitacoraFiltrada = bitacoraList.Where(b => b.FechaBitacora.Date >= dateTimePicker_desde.Value.Date && b.FechaBitacora.Date <= dateTimePicker_hasta.Value.Date).ToList();

                LlenarGrilla(dataGridView1, bitacoraFiltrada);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
