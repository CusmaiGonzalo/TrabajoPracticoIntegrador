namespace GUI
{
    partial class FormularioUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label_usuarioINS = new Label();
            label_contINS = new Label();
            button_agregarUs = new Button();
            dataGridView1 = new DataGridView();
            label_listaus = new Label();
            treeView1 = new TreeView();
            label_permisosdeus = new Label();
            button_verpermisos = new Button();
            button_borrarusuario = new Button();
            button_modificarusuario = new Button();
            dataGridView2 = new DataGridView();
            label_permygrup = new Label();
            button_agregarpermus = new Button();
            button_grupopermiso = new Button();
            textBox_nombreGrupoperm = new TextBox();
            label_nombregrup = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label_grupoPermisos = new Label();
            label_permisos = new Label();
            label_listapermgrup = new Label();
            button_agregarpermagrup = new Button();
            button_verpermigrupo = new Button();
            treeView2 = new TreeView();
            comboBox3 = new ComboBox();
            button_añadirgruafam = new Button();
            label_Grupoagrupo = new Label();
            button_elimpermagru = new Button();
            button_eliminargruagru = new Button();
            button_borrarPermUs = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 36);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 95);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 27);
            textBox2.TabIndex = 1;
            // 
            // label_usuarioINS
            // 
            label_usuarioINS.AutoSize = true;
            label_usuarioINS.Location = new Point(14, 12);
            label_usuarioINS.Name = "label_usuarioINS";
            label_usuarioINS.Size = new Size(59, 20);
            label_usuarioINS.TabIndex = 2;
            label_usuarioINS.Text = "Usuario";
            // 
            // label_contINS
            // 
            label_contINS.AutoSize = true;
            label_contINS.Location = new Point(14, 71);
            label_contINS.Name = "label_contINS";
            label_contINS.Size = new Size(83, 20);
            label_contINS.TabIndex = 3;
            label_contINS.Text = "Contraseña";
            // 
            // button_agregarUs
            // 
            button_agregarUs.Location = new Point(14, 133);
            button_agregarUs.Margin = new Padding(3, 4, 3, 4);
            button_agregarUs.Name = "button_agregarUs";
            button_agregarUs.Size = new Size(233, 41);
            button_agregarUs.TabIndex = 4;
            button_agregarUs.Text = "Agregar Usuario";
            button_agregarUs.UseVisualStyleBackColor = true;
            button_agregarUs.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(253, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(413, 410);
            dataGridView1.TabIndex = 5;
            // 
            // label_listaus
            // 
            label_listaus.AutoSize = true;
            label_listaus.Location = new Point(253, 13);
            label_listaus.Name = "label_listaus";
            label_listaus.Size = new Size(118, 20);
            label_listaus.TabIndex = 6;
            label_listaus.Text = "Lista de usuarios";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(695, 36);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(370, 362);
            treeView1.TabIndex = 7;
            // 
            // label_permisosdeus
            // 
            label_permisosdeus.AutoSize = true;
            label_permisosdeus.Location = new Point(695, 13);
            label_permisosdeus.Name = "label_permisosdeus";
            label_permisosdeus.Size = new Size(144, 20);
            label_permisosdeus.TabIndex = 8;
            label_permisosdeus.Text = "Permisos del usuario";
            // 
            // button_verpermisos
            // 
            button_verpermisos.Location = new Point(695, 406);
            button_verpermisos.Margin = new Padding(3, 4, 3, 4);
            button_verpermisos.Name = "button_verpermisos";
            button_verpermisos.Size = new Size(370, 41);
            button_verpermisos.TabIndex = 9;
            button_verpermisos.Text = "Ver Permisos";
            button_verpermisos.UseVisualStyleBackColor = true;
            button_verpermisos.Click += button_verpermisos_Click;
            // 
            // button_borrarusuario
            // 
            button_borrarusuario.Location = new Point(12, 182);
            button_borrarusuario.Margin = new Padding(3, 4, 3, 4);
            button_borrarusuario.Name = "button_borrarusuario";
            button_borrarusuario.Size = new Size(233, 41);
            button_borrarusuario.TabIndex = 10;
            button_borrarusuario.Text = "Borrar Usuario";
            button_borrarusuario.UseVisualStyleBackColor = true;
            button_borrarusuario.Click += button_borrarusuario_Click;
            // 
            // button_modificarusuario
            // 
            button_modificarusuario.Location = new Point(14, 231);
            button_modificarusuario.Margin = new Padding(3, 4, 3, 4);
            button_modificarusuario.Name = "button_modificarusuario";
            button_modificarusuario.Size = new Size(233, 41);
            button_modificarusuario.TabIndex = 11;
            button_modificarusuario.Text = "Modificar Usuario";
            button_modificarusuario.UseVisualStyleBackColor = true;
            button_modificarusuario.Click += button_modificarusuario_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(253, 497);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(862, 446);
            dataGridView2.TabIndex = 12;
            // 
            // label_permygrup
            // 
            label_permygrup.AutoSize = true;
            label_permygrup.Location = new Point(253, 474);
            label_permygrup.Name = "label_permygrup";
            label_permygrup.Size = new Size(213, 20);
            label_permygrup.TabIndex = 13;
            label_permygrup.Text = "Permisos y grupos de permisos";
            // 
            // button_agregarpermus
            // 
            button_agregarpermus.Location = new Point(14, 497);
            button_agregarpermus.Margin = new Padding(3, 4, 3, 4);
            button_agregarpermus.Name = "button_agregarpermus";
            button_agregarpermus.Size = new Size(233, 41);
            button_agregarpermus.TabIndex = 14;
            button_agregarpermus.Text = "Agregar Permiso a Usuario";
            button_agregarpermus.UseVisualStyleBackColor = true;
            button_agregarpermus.Click += button_agregarpermus_Click;
            // 
            // button_grupopermiso
            // 
            button_grupopermiso.Location = new Point(14, 639);
            button_grupopermiso.Margin = new Padding(3, 4, 3, 4);
            button_grupopermiso.Name = "button_grupopermiso";
            button_grupopermiso.Size = new Size(233, 41);
            button_grupopermiso.TabIndex = 15;
            button_grupopermiso.Text = "Agregar Grupo de Permisos";
            button_grupopermiso.UseVisualStyleBackColor = true;
            button_grupopermiso.Click += button_grupopermiso_Click;
            // 
            // textBox_nombreGrupoperm
            // 
            textBox_nombreGrupoperm.Location = new Point(14, 707);
            textBox_nombreGrupoperm.Name = "textBox_nombreGrupoperm";
            textBox_nombreGrupoperm.Size = new Size(233, 27);
            textBox_nombreGrupoperm.TabIndex = 16;
            // 
            // label_nombregrup
            // 
            label_nombregrup.AutoSize = true;
            label_nombregrup.Location = new Point(14, 684);
            label_nombregrup.Name = "label_nombregrup";
            label_nombregrup.Size = new Size(214, 20);
            label_nombregrup.TabIndex = 17;
            label_nombregrup.Text = "Nombre de grupo de permisos";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1121, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(364, 28);
            comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1121, 90);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(364, 28);
            comboBox2.TabIndex = 19;
            // 
            // label_grupoPermisos
            // 
            label_grupoPermisos.AutoSize = true;
            label_grupoPermisos.Location = new Point(1121, 13);
            label_grupoPermisos.Name = "label_grupoPermisos";
            label_grupoPermisos.Size = new Size(135, 20);
            label_grupoPermisos.TabIndex = 21;
            label_grupoPermisos.Text = "Grupo de permisos";
            // 
            // label_permisos
            // 
            label_permisos.AutoSize = true;
            label_permisos.Location = new Point(1121, 67);
            label_permisos.Name = "label_permisos";
            label_permisos.Size = new Size(67, 20);
            label_permisos.TabIndex = 22;
            label_permisos.Text = "Permisos";
            // 
            // label_listapermgrup
            // 
            label_listapermgrup.AutoSize = true;
            label_listapermgrup.Location = new Point(1121, 121);
            label_listapermgrup.Name = "label_listapermgrup";
            label_listapermgrup.Size = new Size(284, 20);
            label_listapermgrup.TabIndex = 23;
            label_listapermgrup.Text = "Lista de permisos del grupo seleccionado";
            // 
            // button_agregarpermagrup
            // 
            button_agregarpermagrup.Location = new Point(1121, 553);
            button_agregarpermagrup.Margin = new Padding(3, 4, 3, 4);
            button_agregarpermagrup.Name = "button_agregarpermagrup";
            button_agregarpermagrup.Size = new Size(364, 42);
            button_agregarpermagrup.TabIndex = 24;
            button_agregarpermagrup.Text = "Agregar Permisos a Grupo";
            button_agregarpermagrup.UseVisualStyleBackColor = true;
            button_agregarpermagrup.Click += button_agregarpermagrup_Click;
            // 
            // button_verpermigrupo
            // 
            button_verpermigrupo.Location = new Point(1121, 503);
            button_verpermigrupo.Margin = new Padding(3, 4, 3, 4);
            button_verpermigrupo.Name = "button_verpermigrupo";
            button_verpermigrupo.Size = new Size(364, 42);
            button_verpermigrupo.TabIndex = 25;
            button_verpermigrupo.Text = "Ver permisos del grupo";
            button_verpermigrupo.UseVisualStyleBackColor = true;
            button_verpermigrupo.Click += button_verpermigrupo_Click;
            // 
            // treeView2
            // 
            treeView2.Location = new Point(1121, 151);
            treeView2.Name = "treeView2";
            treeView2.Size = new Size(364, 343);
            treeView2.TabIndex = 26;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(1121, 786);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(364, 28);
            comboBox3.TabIndex = 27;
            // 
            // button_añadirgruafam
            // 
            button_añadirgruafam.Location = new Point(1121, 821);
            button_añadirgruafam.Margin = new Padding(3, 4, 3, 4);
            button_añadirgruafam.Name = "button_añadirgruafam";
            button_añadirgruafam.Size = new Size(364, 42);
            button_añadirgruafam.TabIndex = 28;
            button_añadirgruafam.Text = "Añadir grupo a Familia";
            button_añadirgruafam.UseVisualStyleBackColor = true;
            button_añadirgruafam.Click += button_añadirgruafam_Click;
            // 
            // label_Grupoagrupo
            // 
            label_Grupoagrupo.AutoSize = true;
            label_Grupoagrupo.Location = new Point(1121, 763);
            label_Grupoagrupo.Name = "label_Grupoagrupo";
            label_Grupoagrupo.Size = new Size(50, 20);
            label_Grupoagrupo.TabIndex = 29;
            label_Grupoagrupo.Text = "label1";
            // 
            // button_elimpermagru
            // 
            button_elimpermagru.Location = new Point(1121, 603);
            button_elimpermagru.Margin = new Padding(3, 4, 3, 4);
            button_elimpermagru.Name = "button_elimpermagru";
            button_elimpermagru.Size = new Size(364, 42);
            button_elimpermagru.TabIndex = 30;
            button_elimpermagru.Text = "Eliminar Permisos a GRupo";
            button_elimpermagru.UseVisualStyleBackColor = true;
            button_elimpermagru.Click += button_elimpermagru_Click;
            // 
            // button_eliminargruagru
            // 
            button_eliminargruagru.Location = new Point(1121, 653);
            button_eliminargruagru.Margin = new Padding(3, 4, 3, 4);
            button_eliminargruagru.Name = "button_eliminargruagru";
            button_eliminargruagru.Size = new Size(364, 42);
            button_eliminargruagru.TabIndex = 31;
            button_eliminargruagru.Text = "Eliminar Grupo";
            button_eliminargruagru.UseVisualStyleBackColor = true;
            button_eliminargruagru.Click += button_eliminargruagru_Click;
            // 
            // button_borrarPermUs
            // 
            button_borrarPermUs.Location = new Point(14, 546);
            button_borrarPermUs.Margin = new Padding(3, 4, 3, 4);
            button_borrarPermUs.Name = "button_borrarPermUs";
            button_borrarPermUs.Size = new Size(233, 41);
            button_borrarPermUs.TabIndex = 32;
            button_borrarPermUs.Text = "Borrar Permiso de Usuario";
            button_borrarPermUs.UseVisualStyleBackColor = true;
            button_borrarPermUs.Click += button_borrarPermUs_Click;
            // 
            // FormularioUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1667, 1055);
            Controls.Add(button_borrarPermUs);
            Controls.Add(button_eliminargruagru);
            Controls.Add(button_elimpermagru);
            Controls.Add(label_Grupoagrupo);
            Controls.Add(button_añadirgruafam);
            Controls.Add(comboBox3);
            Controls.Add(treeView2);
            Controls.Add(button_verpermigrupo);
            Controls.Add(button_agregarpermagrup);
            Controls.Add(label_listapermgrup);
            Controls.Add(label_permisos);
            Controls.Add(label_grupoPermisos);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label_nombregrup);
            Controls.Add(textBox_nombreGrupoperm);
            Controls.Add(button_grupopermiso);
            Controls.Add(button_agregarpermus);
            Controls.Add(label_permygrup);
            Controls.Add(dataGridView2);
            Controls.Add(button_modificarusuario);
            Controls.Add(button_borrarusuario);
            Controls.Add(button_verpermisos);
            Controls.Add(label_permisosdeus);
            Controls.Add(treeView1);
            Controls.Add(label_listaus);
            Controls.Add(dataGridView1);
            Controls.Add(button_agregarUs);
            Controls.Add(label_contINS);
            Controls.Add(label_usuarioINS);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormularioUsuarios";
            Text = "FormularioUsuarios";
            Load += FormularioUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label_usuarioINS;
        private Label label_contINS;
        private Button button_agregarUs;
        private DataGridView dataGridView1;
        private Label label_listaus;
        private TreeView treeView1;
        private Label label_permisosdeus;
        private Button button_verpermisos;
        private Button button_borrarusuario;
        private Button button_modificarusuario;
        private DataGridView dataGridView2;
        private Label label_permygrup;
        private Button button_agregarpermus;
        private Button button_grupopermiso;
        private TextBox textBox_nombreGrupoperm;
        private Label label_nombregrup;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label_grupoPermisos;
        private Label label_permisos;
        private Label label_listapermgrup;
        private Button button_agregarpermagrup;
        private Button button_verpermigrupo;
        private TreeView treeView2;
        private ComboBox comboBox3;
        private Button button_añadirgruafam;
        private Label label_Grupoagrupo;
        private Button button_elimpermagru;
        private Button button_eliminargruagru;
        private Button button_borrarPermUs;
    }
}