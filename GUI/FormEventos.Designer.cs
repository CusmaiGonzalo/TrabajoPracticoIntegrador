namespace GUI
{
    partial class FormEventos
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
            dataGridView1 = new DataGridView();
            checkBox_tipo = new CheckBox();
            checkBox_error = new CheckBox();
            button_aplicarfiltro = new Button();
            checkBox_sistema = new CheckBox();
            checkBox_usuario = new CheckBox();
            button_filtrarSistema = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(65, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(988, 548);
            dataGridView1.TabIndex = 0;
            // 
            // checkBox_tipo
            // 
            checkBox_tipo.AutoSize = true;
            checkBox_tipo.Location = new Point(1059, 38);
            checkBox_tipo.Name = "checkBox_tipo";
            checkBox_tipo.Size = new Size(101, 24);
            checkBox_tipo.TabIndex = 1;
            checkBox_tipo.Text = "checkBox1";
            checkBox_tipo.UseVisualStyleBackColor = true;
            // 
            // checkBox_error
            // 
            checkBox_error.AutoSize = true;
            checkBox_error.Location = new Point(1059, 68);
            checkBox_error.Name = "checkBox_error";
            checkBox_error.Size = new Size(131, 24);
            checkBox_error.TabIndex = 2;
            checkBox_error.Text = "checkBox_error";
            checkBox_error.UseVisualStyleBackColor = true;
            // 
            // button_aplicarfiltro
            // 
            button_aplicarfiltro.Location = new Point(1059, 128);
            button_aplicarfiltro.Name = "button_aplicarfiltro";
            button_aplicarfiltro.Size = new Size(309, 58);
            button_aplicarfiltro.TabIndex = 3;
            button_aplicarfiltro.Text = "button1";
            button_aplicarfiltro.UseVisualStyleBackColor = true;
            button_aplicarfiltro.Click += button_aplicarfiltro_Click;
            // 
            // checkBox_sistema
            // 
            checkBox_sistema.AutoSize = true;
            checkBox_sistema.Location = new Point(1059, 282);
            checkBox_sistema.Name = "checkBox_sistema";
            checkBox_sistema.Size = new Size(101, 24);
            checkBox_sistema.TabIndex = 4;
            checkBox_sistema.Text = "checkBox1";
            checkBox_sistema.UseVisualStyleBackColor = true;
            // 
            // checkBox_usuario
            // 
            checkBox_usuario.AutoSize = true;
            checkBox_usuario.Location = new Point(1059, 312);
            checkBox_usuario.Name = "checkBox_usuario";
            checkBox_usuario.Size = new Size(101, 24);
            checkBox_usuario.TabIndex = 5;
            checkBox_usuario.Text = "checkBox1";
            checkBox_usuario.UseVisualStyleBackColor = true;
            // 
            // button_filtrarSistema
            // 
            button_filtrarSistema.Location = new Point(1059, 342);
            button_filtrarSistema.Name = "button_filtrarSistema";
            button_filtrarSistema.Size = new Size(309, 58);
            button_filtrarSistema.TabIndex = 6;
            button_filtrarSistema.Text = "button1";
            button_filtrarSistema.UseVisualStyleBackColor = true;
            button_filtrarSistema.Click += button_filtrarSistema_Click;
            // 
            // FormEventos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 700);
            Controls.Add(button_filtrarSistema);
            Controls.Add(checkBox_usuario);
            Controls.Add(checkBox_sistema);
            Controls.Add(button_aplicarfiltro);
            Controls.Add(checkBox_error);
            Controls.Add(checkBox_tipo);
            Controls.Add(dataGridView1);
            Name = "FormEventos";
            Text = "FormEventos";
            Load += FormEventos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private CheckBox checkBox_tipo;
        private CheckBox checkBox_error;
        private Button button_aplicarfiltro;
        private CheckBox checkBox_sistema;
        private CheckBox checkBox_usuario;
        private Button button_filtrarSistema;
    }
}