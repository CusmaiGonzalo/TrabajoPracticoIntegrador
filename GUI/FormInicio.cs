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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            label_bienvenido.Text = $"Bienvenido {SessionManager.Instance.UsuarioLog.NombreUsuario}";
            label_sistema.Text = "Sistema de Gestión de Negocios.\nEl Servicio funiona correctamente.";
        }
    }
}
