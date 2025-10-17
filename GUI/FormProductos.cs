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
    }
}
