namespace GUI
{
    partial class FormProductos
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
            button_agregarprod = new Button();
            comboBox1 = new ComboBox();
            textBox_nombreproducto = new TextBox();
            textBox_precioproducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(222, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1071, 497);
            dataGridView1.TabIndex = 0;
            // 
            // button_agregarprod
            // 
            button_agregarprod.Location = new Point(12, 38);
            button_agregarprod.Name = "button_agregarprod";
            button_agregarprod.Size = new Size(204, 60);
            button_agregarprod.TabIndex = 1;
            button_agregarprod.Text = "Agregar Producto";
            button_agregarprod.UseVisualStyleBackColor = true;
            button_agregarprod.Click += button_agregarprod_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 209);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 28);
            comboBox1.TabIndex = 2;
            // 
            // textBox_nombreproducto
            // 
            textBox_nombreproducto.Location = new Point(12, 147);
            textBox_nombreproducto.Name = "textBox_nombreproducto";
            textBox_nombreproducto.Size = new Size(204, 27);
            textBox_nombreproducto.TabIndex = 3;
            // 
            // textBox_precioproducto
            // 
            textBox_precioproducto.Location = new Point(12, 287);
            textBox_precioproducto.Name = "textBox_precioproducto";
            textBox_precioproducto.Size = new Size(204, 27);
            textBox_precioproducto.TabIndex = 4;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 810);
            Controls.Add(textBox_precioproducto);
            Controls.Add(textBox_nombreproducto);
            Controls.Add(comboBox1);
            Controls.Add(button_agregarprod);
            Controls.Add(dataGridView1);
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button_agregarprod;
        private ComboBox comboBox1;
        private TextBox textBox_nombreproducto;
        private TextBox textBox_precioproducto;
    }
}