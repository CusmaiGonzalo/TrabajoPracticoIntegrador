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
            button_aplicarDescuento = new Button();
            label_descuento = new Label();
            textBox_descuento = new TextBox();
            label_preciofinal = new Label();
            textBox_preciofinal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button_nuevoPedido
            // 
            button_nuevoPedido.Location = new Point(13, 34);
            button_nuevoPedido.Name = "button_nuevoPedido";
            button_nuevoPedido.Size = new Size(226, 58);
            button_nuevoPedido.TabIndex = 0;
            button_nuevoPedido.Text = "Nuevo Pedido";
            button_nuevoPedido.UseVisualStyleBackColor = true;
            button_nuevoPedido.Click += button_nuevoPedido_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(245, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1144, 494);
            dataGridView1.TabIndex = 1;
            // 
            // button_agregarProducto
            // 
            button_agregarProducto.Location = new Point(13, 549);
            button_agregarProducto.Name = "button_agregarProducto";
            button_agregarProducto.Size = new Size(226, 58);
            button_agregarProducto.TabIndex = 2;
            button_agregarProducto.Text = "Agregar Producto";
            button_agregarProducto.UseVisualStyleBackColor = true;
            button_agregarProducto.Click += button_agregarProducto_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(245, 549);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1144, 410);
            dataGridView2.TabIndex = 3;
            // 
            // label_pedido
            // 
            label_pedido.AutoSize = true;
            label_pedido.Location = new Point(245, 531);
            label_pedido.Name = "label_pedido";
            label_pedido.Size = new Size(48, 15);
            label_pedido.TabIndex = 4;
            label_pedido.Text = "PEDIDO";
            // 
            // label_prods
            // 
            label_prods.AutoSize = true;
            label_prods.Location = new Point(245, 16);
            label_prods.Name = "label_prods";
            label_prods.Size = new Size(74, 15);
            label_prods.TabIndex = 5;
            label_prods.Text = "PRODUCTOS";
            // 
            // textBox_nomcliente
            // 
            textBox_nomcliente.Location = new Point(13, 112);
            textBox_nomcliente.Margin = new Padding(3, 2, 3, 2);
            textBox_nomcliente.Name = "textBox_nomcliente";
            textBox_nomcliente.Size = new Size(226, 23);
            textBox_nomcliente.TabIndex = 6;
            // 
            // label_nomCliente
            // 
            label_nomCliente.AutoSize = true;
            label_nomCliente.Location = new Point(13, 94);
            label_nomCliente.Name = "label_nomCliente";
            label_nomCliente.Size = new Size(107, 15);
            label_nomCliente.TabIndex = 7;
            label_nomCliente.Text = "Nombre de Cliente";
            // 
            // button_confirmarpedido
            // 
            button_confirmarpedido.Location = new Point(10, 199);
            button_confirmarpedido.Name = "button_confirmarpedido";
            button_confirmarpedido.Size = new Size(226, 58);
            button_confirmarpedido.TabIndex = 8;
            button_confirmarpedido.Text = "Confirmar Pedido";
            button_confirmarpedido.UseVisualStyleBackColor = true;
            button_confirmarpedido.Click += button_confirmarpedido_Click;
            // 
            // textBox_verprecio
            // 
            textBox_verprecio.Location = new Point(10, 277);
            textBox_verprecio.Margin = new Padding(3, 2, 3, 2);
            textBox_verprecio.Name = "textBox_verprecio";
            textBox_verprecio.Size = new Size(226, 23);
            textBox_verprecio.TabIndex = 10;
            // 
            // label_preciototal
            // 
            label_preciototal.AutoSize = true;
            label_preciototal.Location = new Point(10, 260);
            label_preciototal.Name = "label_preciototal";
            label_preciototal.Size = new Size(67, 15);
            label_preciototal.TabIndex = 11;
            label_preciototal.Text = "Precio total";
            // 
            // button_aplicarDescuento
            // 
            button_aplicarDescuento.Location = new Point(10, 470);
            button_aplicarDescuento.Name = "button_aplicarDescuento";
            button_aplicarDescuento.Size = new Size(226, 58);
            button_aplicarDescuento.TabIndex = 12;
            button_aplicarDescuento.Text = "Aplicar Descuento";
            button_aplicarDescuento.UseVisualStyleBackColor = true;
            button_aplicarDescuento.Click += button_aplicarDescuento_Click;
            // 
            // label_descuento
            // 
            label_descuento.AutoSize = true;
            label_descuento.Location = new Point(10, 302);
            label_descuento.Name = "label_descuento";
            label_descuento.Size = new Size(63, 15);
            label_descuento.TabIndex = 13;
            label_descuento.Text = "Descuento";
            // 
            // textBox_descuento
            // 
            textBox_descuento.Location = new Point(10, 320);
            textBox_descuento.Name = "textBox_descuento";
            textBox_descuento.Size = new Size(226, 23);
            textBox_descuento.TabIndex = 14;
            // 
            // label_preciofinal
            // 
            label_preciofinal.AutoSize = true;
            label_preciofinal.Location = new Point(10, 346);
            label_preciofinal.Name = "label_preciofinal";
            label_preciofinal.Size = new Size(68, 15);
            label_preciofinal.TabIndex = 15;
            label_preciofinal.Text = "Precio Final";
            // 
            // textBox_preciofinal
            // 
            textBox_preciofinal.Location = new Point(10, 364);
            textBox_preciofinal.Name = "textBox_preciofinal";
            textBox_preciofinal.Size = new Size(226, 23);
            textBox_preciofinal.TabIndex = 16;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1007);
            Controls.Add(textBox_preciofinal);
            Controls.Add(label_preciofinal);
            Controls.Add(textBox_descuento);
            Controls.Add(label_descuento);
            Controls.Add(button_aplicarDescuento);
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
        private Button button_aplicarDescuento;
        private Label label_descuento;
        private TextBox textBox_descuento;
        private Label label_preciofinal;
        private TextBox textBox_preciofinal;
    }
}