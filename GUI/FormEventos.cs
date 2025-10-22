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
    public partial class FormEventos : Form
    {
        BLL.GestionUsuarios gestorUsuarios;
        List<BE.BITACORA> bitacoraList;
        public FormEventos()
        {
            InitializeComponent();
            gestorUsuarios = new BLL.GestionUsuarios();
            bitacoraList = new List<BE.BITACORA>();
        }

        private void FormEventos_Load(object sender, EventArgs e)
        {
            bitacoraList = gestorUsuarios.ListarBitacora();
            LlenarGrilla(dataGridView1, bitacoraList);
        }

        private void LlenarGrilla(DataGridView grilla, object datos)
        {
            grilla.DataSource = null;
            grilla.DataSource = datos;
        }
    }
}
