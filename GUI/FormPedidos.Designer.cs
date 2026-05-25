namespace GUI
{
    partial class FormPedidos
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
            button_nuevoPedido = new Button();
            dataGridView1 = new DataGridView();
            button_agregarProducto = new Button();
            dataGridView2 = new DataGridView();
            label_pedido = new Label();
            label_prods = new Label();
            textBox_nomcliente = new TextBox();
            label_nomCliente = new Label();
            button_confirmarpedido = new Button();
            textBox_verprecio = new TextBox();
            label_preciototal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button_nuevoPedido
            // 
            button_nuevoPedido.Location = new Point(15, 45);
            button_nuevoPedido.Margin = new Padding(3, 4, 3, 4);
            button_nuevoPedido.Name = "button_nuevoPedido";
            button_nuevoPedido.Size = new Size(258, 77);
            button_nuevoPedido.TabIndex = 0;
            button_nuevoPedido.Text = "Nuevo Pedido";
            button_nuevoPedido.UseVisualStyleBackColor = true;
            button_nuevoPedido.Click += button_nuevoPedido_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(280, 45);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1307, 659);
            dataGridView1.TabIndex = 1;
            // 
            // button_agregarProducto
            // 
            button_agregarProducto.Location = new Point(15, 732);
            button_agregarProducto.Margin = new Padding(3, 4, 3, 4);
            button_agregarProducto.Name = "button_agregarProducto";
            button_agregarProducto.Size = new Size(258, 77);
            button_agregarProducto.TabIndex = 2;
            button_agregarProducto.Text = "Agregar Producto";
            button_agregarProducto.UseVisualStyleBackColor = true;
            button_agregarProducto.Click += button_agregarProducto_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(280, 732);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1307, 547);
            dataGridView2.TabIndex = 3;
            // 
            // label_pedido
            // 
            label_pedido.AutoSize = true;
            label_pedido.Location = new Point(280, 708);
            label_pedido.Name = "label_pedido";
            label_pedido.Size = new Size(62, 20);
            label_pedido.TabIndex = 4;
            label_pedido.Text = "PEDIDO";
            // 
            // label_prods
            // 
            label_prods.AutoSize = true;
            label_prods.Location = new Point(280, 21);
            label_prods.Name = "label_prods";
            label_prods.Size = new Size(93, 20);
            label_prods.TabIndex = 5;
            label_prods.Text = "PRODUCTOS";
            // 
            // textBox_nomcliente
            // 
            textBox_nomcliente.Location = new Point(15, 149);
            textBox_nomcliente.Name = "textBox_nomcliente";
            textBox_nomcliente.Size = new Size(258, 27);
            textBox_nomcliente.TabIndex = 6;
            // 
            // label_nomCliente
            // 
            label_nomCliente.AutoSize = true;
            label_nomCliente.Location = new Point(15, 126);
            label_nomCliente.Name = "label_nomCliente";
            label_nomCliente.Size = new Size(135, 20);
            label_nomCliente.TabIndex = 7;
            label_nomCliente.Text = "Nombre de Cliente";
            // 
            // button_confirmarpedido
            // 
            button_confirmarpedido.Location = new Point(12, 345);
            button_confirmarpedido.Margin = new Padding(3, 4, 3, 4);
            button_confirmarpedido.Name = "button_confirmarpedido";
            button_confirmarpedido.Size = new Size(258, 77);
            button_confirmarpedido.TabIndex = 8;
            button_confirmarpedido.Text = "Confirmar Pedido";
            button_confirmarpedido.UseVisualStyleBackColor = true;
            button_confirmarpedido.Click += button_confirmarpedido_Click;
            // 
            // textBox_verprecio
            // 
            textBox_verprecio.Location = new Point(13, 311);
            textBox_verprecio.Name = "textBox_verprecio";
            textBox_verprecio.Size = new Size(258, 27);
            textBox_verprecio.TabIndex = 10;
            // 
            // label_preciototal
            // 
            label_preciototal.AutoSize = true;
            label_preciototal.Location = new Point(15, 288);
            label_preciototal.Name = "label_preciototal";
            label_preciototal.Size = new Size(85, 20);
            label_preciototal.TabIndex = 11;
            label_preciototal.Text = "Precio total";
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1878, 1055);
            Controls.Add(label_preciototal);
            Controls.Add(textBox_verprecio);
            Controls.Add(button_confirmarpedido);
            Controls.Add(label_nomCliente);
            Controls.Add(textBox_nomcliente);
            Controls.Add(label_prods);
            Controls.Add(label_pedido);
            Controls.Add(dataGridView2);
            Controls.Add(button_agregarProducto);
            Controls.Add(dataGridView1);
            Controls.Add(button_nuevoPedido);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPedidos";
            Text = "FormPedidos";
            Load += FormPedidos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_nuevoPedido;
        private DataGridView dataGridView1;
        private Button button_agregarProducto;
        private DataGridView dataGridView2;
        private Label label_pedido;
        private Label label_prods;
        private TextBox textBox_nomcliente;
        private Label label_nomCliente;
        private Button button_confirmarpedido;
        private TextBox textBox_verprecio;
        private Label label_preciototal;
    }
}