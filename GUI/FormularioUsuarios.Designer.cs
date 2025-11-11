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
            label1 = new Label();
            treeView1 = new TreeView();
            label2 = new Label();
            button_verpermisos = new Button();
            button_borrarusuario = new Button();
            button_modificarusuario = new Button();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            button_agregarpermus = new Button();
            button_grupopermiso = new Button();
            textBox_nombreGrupoperm = new TextBox();
            label4 = new Label();
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
            dataGridView1.Size = new Size(347, 410);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 13);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(606, 36);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(320, 362);
            treeView1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(606, 12);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // button_verpermisos
            // 
            button_verpermisos.Location = new Point(606, 405);
            button_verpermisos.Margin = new Padding(3, 4, 3, 4);
            button_verpermisos.Name = "button_verpermisos";
            button_verpermisos.Size = new Size(320, 41);
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
            dataGridView2.Size = new Size(673, 514);
            dataGridView2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 474);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 13;
            label3.Text = "label3";
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
            button_grupopermiso.Location = new Point(14, 546);
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
            textBox_nombreGrupoperm.Location = new Point(14, 614);
            textBox_nombreGrupoperm.Name = "textBox_nombreGrupoperm";
            textBox_nombreGrupoperm.Size = new Size(233, 27);
            textBox_nombreGrupoperm.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 591);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 17;
            label4.Text = "label4";
            // 
            // FormularioUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1446, 1055);
            Controls.Add(label4);
            Controls.Add(textBox_nombreGrupoperm);
            Controls.Add(button_grupopermiso);
            Controls.Add(button_agregarpermus);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(button_modificarusuario);
            Controls.Add(button_borrarusuario);
            Controls.Add(button_verpermisos);
            Controls.Add(label2);
            Controls.Add(treeView1);
            Controls.Add(label1);
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
        private Label label1;
        private TreeView treeView1;
        private Label label2;
        private Button button_verpermisos;
        private Button button_borrarusuario;
        private Button button_modificarusuario;
        private DataGridView dataGridView2;
        private Label label3;
        private Button button_agregarpermus;
        private Button button_grupopermiso;
        private TextBox textBox_nombreGrupoperm;
        private Label label4;
    }
}