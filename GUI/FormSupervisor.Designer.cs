namespace GUI
{
    partial class FormSupervisor
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
            label_pedido = new Label();
            label_filtrar = new Label();
            comboBox1 = new ComboBox();
            button_aplicarfiltro = new Button();
            button_devolvercocina = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(768, 458);
            dataGridView1.TabIndex = 0;
            // 
            // label_pedido
            // 
            label_pedido.AutoSize = true;
            label_pedido.Location = new Point(12, 9);
            label_pedido.Name = "label_pedido";
            label_pedido.Size = new Size(74, 15);
            label_pedido.TabIndex = 1;
            label_pedido.Text = "label_pedido";
            // 
            // label_filtrar
            // 
            label_filtrar.AutoSize = true;
            label_filtrar.Location = new Point(786, 9);
            label_filtrar.Name = "label_filtrar";
            label_filtrar.Size = new Size(38, 15);
            label_filtrar.TabIndex = 2;
            label_filtrar.Text = "label1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(786, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 23);
            comboBox1.TabIndex = 3;
            // 
            // button_aplicarfiltro
            // 
            button_aplicarfiltro.Location = new Point(786, 27);
            button_aplicarfiltro.Name = "button_aplicarfiltro";
            button_aplicarfiltro.Size = new Size(215, 49);
            button_aplicarfiltro.TabIndex = 4;
            button_aplicarfiltro.Text = "Aplicar filtro";
            button_aplicarfiltro.UseVisualStyleBackColor = true;
            button_aplicarfiltro.Click += button_aplicarfiltro_Click;
            // 
            // button_devolvercocina
            // 
            button_devolvercocina.Location = new Point(786, 436);
            button_devolvercocina.Name = "button_devolvercocina";
            button_devolvercocina.Size = new Size(215, 49);
            button_devolvercocina.TabIndex = 5;
            button_devolvercocina.Text = "Devolver a COCINA";
            button_devolvercocina.UseVisualStyleBackColor = true;
            button_devolvercocina.Click += button_devolvercocina_Click;
            // 
            // FormSupervisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1577, 878);
            Controls.Add(button_devolvercocina);
            Controls.Add(button_aplicarfiltro);
            Controls.Add(comboBox1);
            Controls.Add(label_filtrar);
            Controls.Add(label_pedido);
            Controls.Add(dataGridView1);
            Name = "FormSupervisor";
            Text = "FormSupervisor";
            Load += FormSupervisor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label_pedido;
        private Label label_filtrar;
        private ComboBox comboBox1;
        private Button button_aplicarfiltro;
        private Button button_devolvercocina;
    }
}