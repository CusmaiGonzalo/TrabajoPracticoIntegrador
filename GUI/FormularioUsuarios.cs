using BE;
using BLL;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
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
using static Azure.Core.HttpHeader;

namespace GUI
{
    public partial class FormularioUsuarios : Form, IObserver
    {
        BLL.GestionUsuarios gestorUsuarios;
        BLL.GestionIdioma gestorIdioma;
        BLL.GestionPermisos gestorPermisos;
        FAMILIA familiaseleecionada;
        BE.BITACORA nuevaBitacora = new BITACORA();
        BLL.GestionBitacora gestorBitacora = new BLL.GestionBitacora();
        public FormularioUsuarios(GestionIdioma idiomasFormPrincipal)
        {
            InitializeComponent();
            gestorUsuarios = new BLL.GestionUsuarios();
            gestorPermisos = new BLL.GestionPermisos();
            familiaseleecionada = new FAMILIA();
            gestorIdioma = idiomasFormPrincipal;
            gestorIdioma.Agregar(this);
            Traducir(gestorIdioma.IdiomaActual);
            PATENTE permisoAgregaruUsuario = new PATENTE() { IDPatente = 5 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoAgregaruUsuario, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_agregarUs.Enabled = false;
            }
            PATENTE permisoBorrarUsu = new PATENTE() { IDPatente = 22 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoBorrarUsu, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_borrarusuario.Enabled = false;
            }
            PATENTE permisoModUsu = new PATENTE() { IDPatente = 23 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoModUsu, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_modificarusuario.Enabled = false;
            }
            PATENTE permisoVerPermi = new PATENTE() { IDPatente = 24 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoVerPermi, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_verpermisos.Enabled = false;
            }
            PATENTE permisoAgregarPermaUsu = new PATENTE() { IDPatente = 25 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoAgregarPermaUsu, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_agregarpermus.Enabled = false;
            }
            PATENTE permisoAgregarGruPerm = new PATENTE() { IDPatente = 26 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoAgregarGruPerm, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_grupopermiso.Enabled = false;
            }
            PATENTE permisoVerPermGru = new PATENTE() { IDPatente = 27 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoVerPermGru, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_verpermigrupo.Enabled = false;
            }
            PATENTE permisoAgregarPermGrup = new PATENTE() { IDPatente = 28 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoAgregarPermGrup, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_agregarpermagrup.Enabled = false;
            }
            PATENTE permisoElimPeraGrup = new PATENTE() { IDPatente = 29 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoElimPeraGrup, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_elimpermagru.Enabled = false;
            }
            PATENTE permisoEliminarGrupo = new PATENTE() { IDPatente = 30 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoEliminarGrupo, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_eliminargruagru.Enabled = false;
            }
            PATENTE permisoAñadirGruafam = new PATENTE() { IDPatente = 31 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoAñadirGruafam, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_añadirgruafam.Enabled = false;
            }
            PATENTE permisoBorrarPermUsu = new PATENTE() { IDPatente = 32 };
            if (gestorPermisos.ValidarPermisosDeUsuario(permisoBorrarPermUsu, Servicios.SessionManager.Instance.UsuarioLog) == false)
            {
                button_borrarPermUs.Enabled = false;
            }
            EstiloGrilla(dataGridView1);
            EstiloGrilla(dataGridView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    BE.USUARIO nuevoUsuario = new BE.USUARIO();
                    nuevoUsuario.NombreUsuario = textBox1.Text;
                    nuevoUsuario.Contraseña = textBox2.Text;
                    gestorUsuarios.AgregarUsuario(nuevoUsuario);
                    LlenarGrilla(dataGridView1, gestorUsuarios.ListarUsuarios());
                    nuevaBitacora = Bitacora.EventoBitacora("Se agrego Usuario nuevo.");
                    gestorBitacora.RegistrarBitacora(nuevaBitacora);
                }
                else { throw new Exception("Complete todos los datos"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void FormularioUsuarios_FormClosing(object sender, FormClosingEventArgs e)
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

        private void LlenarGrilla(DataGridView grilla, object datos)
        {
            grilla.DataSource = null;
            grilla.DataSource = datos;
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
        private void LlenarComboBox(ComboBox comboBox, object datos)
        {
            comboBox.DataSource = null;
            comboBox.DataSource = datos;
            comboBox.DisplayMember = "NombrePatente";
            comboBox.ValueMember = "IDPatente";
            comboBox.SelectedIndex = 0;
        }
        private void FormularioUsuarios_Load(object sender, EventArgs e)
        {
            LlenarGrilla(dataGridView1, gestorUsuarios.ListarUsuarios());
            LlenarGrilla(dataGridView2, gestorPermisos.ListarPermisos());
            LlenarComboBox(comboBox1, gestorPermisos.ListarSoloFamilias());
            LlenarComboBox(comboBox2, gestorPermisos.ListarSoloPermisos());
            LlenarComboBox(comboBox3, gestorPermisos.ListarSoloFamilias());
            familiaseleecionada = null;
        }

        private void button_verpermisos_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Clear();
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un usuario para ver sus permisos.", "Seleccionar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                BE.USUARIO usuarioSeleccionado = dataGridView1.SelectedRows[0].DataBoundItem as USUARIO;
                usuarioSeleccionado = gestorPermisos.CargarPermisosUsuario(usuarioSeleccionado);

                CargarPermisosEnTreeView(usuarioSeleccionado.ListaPermisos, treeView1);
                nuevaBitacora = Bitacora.EventoBitacora("Se solicito ver permisos del usuario en TreeView.");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarPermisosEnTreeView(List<COMPONENTE> listaPermisos, TreeView arbol)
        {
            try
            {
                if (listaPermisos == null || listaPermisos.Count == 0)
                {
                    TreeNode nodoSinPermisos = new TreeNode("El usuario no tiene permisos asignados");
                    nodoSinPermisos.ForeColor = Color.Gray;
                    arbol.Nodes.Add(nodoSinPermisos);
                    return;
                }
                foreach (COMPONENTE compo in listaPermisos)
                {
                    if (compo is PATENTE)
                    {
                        PATENTE permiso = (PATENTE)compo;
                        TreeNode nodoPatente = new TreeNode($"🔐 {permiso.NombrePatente}");
                        nodoPatente.Tag = permiso;
                        nodoPatente.ForeColor = Color.DarkGreen;
                        arbol.Nodes.Add(nodoPatente);
                    }
                    else
                    if (compo is FAMILIA)
                    {
                        FAMILIA permisos = (FAMILIA)compo;
                        TreeNode nodoFamilia = new TreeNode($"👥 {permisos.NombrePatente}");
                        nodoFamilia.Tag = permisos;
                        nodoFamilia.ForeColor = Color.DarkBlue;
                        nodoFamilia.NodeFont = new Font(treeView1.Font, FontStyle.Bold);
                        arbol.Nodes.Add(nodoFamilia);
                        CargarFamilias(nodoFamilia, permisos.listaComponentes);
                    }
                }
                arbol.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar permisos en TreeView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private TreeNode CargarFamilias(TreeNode nodo, List<COMPONENTE> listaCompo)
        {
            foreach (COMPONENTE compo in listaCompo)
            {
                if (compo is PATENTE)
                {
                    PATENTE permiso = (PATENTE)compo;
                    TreeNode nodoPatente = new TreeNode($"🔐 {permiso.NombrePatente}");
                    nodoPatente.Tag = permiso;
                    nodoPatente.ForeColor = Color.DarkGreen;
                    nodo.Nodes.Add(nodoPatente);
                }
                else
                if (compo is FAMILIA)
                {
                    FAMILIA permisos = (FAMILIA)compo;
                    TreeNode nodoFamilia = new TreeNode($"👥 {permisos.NombrePatente}");
                    nodoFamilia.Tag = permisos;
                    nodoFamilia.ForeColor = Color.DarkBlue;
                    nodoFamilia.NodeFont = new Font(treeView1.Font, FontStyle.Bold);
                    nodo.Nodes.Add(nodoFamilia);
                    CargarFamilias(nodoFamilia, permisos.listaComponentes);
                }
            }
            return nodo;
        }

        private void button_borrarusuario_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO userseleccionado = dataGridView1.SelectedRows[0].DataBoundItem as USUARIO;
                gestorUsuarios.BorrarUsuario(userseleccionado);
                LlenarGrilla(dataGridView1, gestorUsuarios.ListarUsuarios());
                nuevaBitacora = Bitacora.EventoBitacora("Se borro un Usuario.");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_modificarusuario_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO userseleccionado = dataGridView1.SelectedRows[0].DataBoundItem as USUARIO;
                USUARIO usermodificado = new USUARIO();
                usermodificado.NombreUsuario = Interaction.InputBox("Ingrese nuevo nombre de usuario:", "Modificar Usuario", $"{userseleccionado.NombreUsuario}");
                gestorUsuarios.ModificarUsuario(userseleccionado, usermodificado);
                LlenarGrilla(dataGridView1, gestorUsuarios.ListarUsuarios());
                nuevaBitacora = Bitacora.EventoBitacora("Se modifico el nombre de un Usuario.");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_agregarpermus_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO usuarioseleccionado = dataGridView1.SelectedRows[0].DataBoundItem as USUARIO;
                usuarioseleccionado.ListaPermisos = gestorPermisos.CargarPermisosUsuario(usuarioseleccionado).ListaPermisos;
                PATENTE patenteseleccionada = dataGridView2.SelectedRows[0].DataBoundItem as PATENTE;
                gestorUsuarios.AgregarPermisoAUsuario(usuarioseleccionado, patenteseleccionada);
                MessageBox.Show("Patente agregada correctamente", "PERMISOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nuevaBitacora = Bitacora.EventoBitacora("Agregar permisos a Usuario.");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_grupopermiso_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_nombreGrupoperm.Text == "") { throw new Exception("Completar los campos."); }
                FAMILIA nuevafamilia = new FAMILIA();
                nuevafamilia.NombrePatente = textBox_nombreGrupoperm.Text;
                gestorPermisos.InsertarGrupoPermiso(nuevafamilia);
                LlenarGrilla(dataGridView2, gestorPermisos.ListarPermisos());
                LlenarComboBox(comboBox1, gestorPermisos.ListarSoloFamilias());
                LlenarComboBox(comboBox3, gestorPermisos.ListarSoloFamilias());
                nuevaBitacora = Bitacora.EventoBitacora("Se agrego un nuevo grupo de permisos.");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_verpermigrupo_Click(object sender, EventArgs e)
        {
            try
            {
                familiaseleecionada = null;
                familiaseleecionada = (FAMILIA)comboBox1.SelectedItem;
                treeView2.Nodes.Clear();
                CargarPermisosEnTreeView(gestorPermisos.ListarPatentesDeGrupo(familiaseleecionada), treeView2);
                nuevaBitacora = Bitacora.EventoBitacora("Se solicito ver un grupo especifico de permisos en TreeView.");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_agregarpermagrup_Click(object sender, EventArgs e)
        {
            try
            {
                if (familiaseleecionada == null)
                {
                    throw new Exception("Seleccione una familia tocando el boton 'Ver Permisos del Grupo'.");
                }
                PATENTE patenteseleccionada = new PATENTE();
                patenteseleccionada = (PATENTE)comboBox2.SelectedItem;
                gestorPermisos.InsertarPatenteAGrupo(familiaseleecionada, patenteseleccionada);
                MessageBox.Show("Permiso añadido correctamente.", "PERMISOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                familiaseleecionada.listaComponentes = null;
                familiaseleecionada.listaComponentes = gestorPermisos.ListarPatentesDeGrupo(familiaseleecionada);
                nuevaBitacora = Bitacora.EventoBitacora("Se agrego permisos a un grupo.");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_añadirgruafam_Click(object sender, EventArgs e)
        {
            try
            {
                FAMILIA familiaHija = new FAMILIA();
                familiaHija = (FAMILIA)comboBox3.SelectedItem;
                familiaHija.listaComponentes = gestorPermisos.ListarPatentesDeGrupo(familiaHija);

                if (ServicioPermisos.ValidarPermisosGeneral(familiaseleecionada, familiaHija.listaComponentes))
                {
                    throw new Exception("No se puede agregar este grupo de permisos porque ya existe dentro del grupo seleccionado o se genera una referencia circular.");
                }
                
                if (familiaseleecionada == null)
                {
                    throw new Exception("Seleccione una familia tocando el boton 'Ver Permisos del Grupo'.");
                }
                gestorPermisos.AgregarGrupoAFamilia(familiaseleecionada, familiaHija);
                MessageBox.Show("Grupo añadido correctamente.", "PERMISOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                familiaseleecionada.listaComponentes = null;
                familiaseleecionada.listaComponentes = gestorPermisos.ListarPatentesDeGrupo(familiaseleecionada);
                nuevaBitacora = Bitacora.EventoBitacora("Se añadio grupo de permisos a otro grupo de permisos.");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_elimpermagru_Click(object sender, EventArgs e)
        {
            try
            {
                if (familiaseleecionada == null)
                {
                    throw new Exception("Seleccione una familia tocando el boton 'Ver Permisos del Grupo'.");
                }
                PATENTE patenteseleccionada = new PATENTE();
                patenteseleccionada = (PATENTE)comboBox2.SelectedItem;
                gestorPermisos.EliminarPatenteDeGrupo(familiaseleecionada, patenteseleccionada);
                MessageBox.Show("Permiso eliminado correctamente.", "PERMISOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                familiaseleecionada.listaComponentes = null;
                familiaseleecionada.listaComponentes = gestorPermisos.ListarPatentesDeGrupo(familiaseleecionada);
                nuevaBitacora = Bitacora.EventoBitacora("Se elimino permisos de un grupo.");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_eliminargruagru_Click(object sender, EventArgs e)
        {
            try
            {
                if (familiaseleecionada == null)
                {
                    throw new Exception("Seleccione una familia tocando el boton 'Ver Permisos del Grupo'.");
                }
                gestorPermisos.EliminarGrupo(familiaseleecionada);
                MessageBox.Show("Grupo eliminado correctamente.", "PERMISOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                familiaseleecionada.listaComponentes = null;
                familiaseleecionada.listaComponentes = gestorPermisos.ListarPatentesDeGrupo(familiaseleecionada);
                LlenarComboBox(comboBox1, gestorPermisos.ListarSoloFamilias());
                LlenarComboBox(comboBox3, gestorPermisos.ListarSoloFamilias());
                nuevaBitacora = Bitacora.EventoBitacora("Se borro un grupo de permisos.");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_borrarPermUs_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIO usuarioseleccionado = new USUARIO();
                usuarioseleccionado = dataGridView1.SelectedRows[0].DataBoundItem as USUARIO;
                usuarioseleccionado.ListaPermisos = gestorPermisos.CargarPermisosUsuario(usuarioseleccionado).ListaPermisos;
                PATENTE patenteseleccionada = new PATENTE();
                patenteseleccionada = dataGridView2.SelectedRows[0].DataBoundItem as PATENTE;
                gestorUsuarios.QuitarPermisoAUsuario(usuarioseleccionado, patenteseleccionada);
                MessageBox.Show("Patente quitada correctamente", "PERMISOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nuevaBitacora = Bitacora.EventoBitacora("Quita permisos a Usuario.");
                gestorBitacora.RegistrarBitacora(nuevaBitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
