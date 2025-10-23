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
            label_nombreprod = new Label();
            label_productos = new Label();
            label_tipoprod = new Label();
            label_precioprod = new Label();
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
            comboBox1.Location = new Point(12, 177);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 28);
            comboBox1.TabIndex = 2;
            // 
            // textBox_nombreproducto
            // 
            textBox_nombreproducto.Location = new Point(12, 124);
            textBox_nombreproducto.Name = "textBox_nombreproducto";
            textBox_nombreproducto.Size = new Size(204, 27);
            textBox_nombreproducto.TabIndex = 3;
            // 
            // textBox_precioproducto
            // 
            textBox_precioproducto.Location = new Point(12, 231);
            textBox_precioproducto.Name = "textBox_precioproducto";
            textBox_precioproducto.Size = new Size(204, 27);
            textBox_precioproducto.TabIndex = 4;
            // 
            // label_nombreprod
            // 
            label_nombreprod.AutoSize = true;
            label_nombreprod.Location = new Point(12, 101);
            label_nombreprod.Name = "label_nombreprod";
            label_nombreprod.Size = new Size(154, 20);
            label_nombreprod.TabIndex = 5;
            label_nombreprod.Text = "Nombre del producto";
            // 
            // label_productos
            // 
            label_productos.AutoSize = true;
            label_productos.Location = new Point(222, 9);
            label_productos.Name = "label_productos";
            label_productos.Size = new Size(75, 20);
            label_productos.TabIndex = 6;
            label_productos.Text = "Productos";
            // 
            // label_tipoprod
            // 
            label_tipoprod.AutoSize = true;
            label_tipoprod.Location = new Point(12, 154);
            label_tipoprod.Name = "label_tipoprod";
            label_tipoprod.Size = new Size(39, 20);
            label_tipoprod.TabIndex = 7;
            label_tipoprod.Text = "Tipo";
            // 
            // label_precioprod
            // 
            label_precioprod.AutoSize = true;
            label_precioprod.Location = new Point(12, 208);
            label_precioprod.Name = "label_precioprod";
            label_precioprod.Size = new Size(50, 20);
            label_precioprod.TabIndex = 8;
            label_precioprod.Text = "Precio";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 810);
            Controls.Add(label_precioprod);
            Controls.Add(label_tipoprod);
            Controls.Add(label_productos);
            Controls.Add(label_nombreprod);
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
        private Label label_nombreprod;
        private Label label_productos;
        private Label label_tipoprod;
        private Label label_precioprod;
    }
}