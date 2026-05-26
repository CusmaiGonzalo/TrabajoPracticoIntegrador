namespace GUI
{
    partial class FormCocina
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
            label_producto = new Label();
            dataGridView2 = new DataGridView();
            button_verpedido = new Button();
            button_sacarPedido = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(228, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(789, 363);
            dataGridView1.TabIndex = 0;
            // 
            // label_pedido
            // 
            label_pedido.AutoSize = true;
            label_pedido.Location = new Point(228, 9);
            label_pedido.Name = "label_pedido";
            label_pedido.Size = new Size(38, 15);
            label_pedido.TabIndex = 1;
            label_pedido.Text = "label1";
            // 
            // label_producto
            // 
            label_producto.AutoSize = true;
            label_producto.Location = new Point(228, 393);
            label_producto.Name = "label_producto";
            label_producto.Size = new Size(86, 15);
            label_producto.TabIndex = 2;
            label_producto.Text = "label_producto";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(228, 411);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(789, 331);
            dataGridView2.TabIndex = 3;
            // 
            // button_verpedido
            // 
            button_verpedido.Location = new Point(12, 27);
            button_verpedido.Name = "button_verpedido";
            button_verpedido.Size = new Size(210, 52);
            button_verpedido.TabIndex = 4;
            button_verpedido.Text = "Ver Pedido";
            button_verpedido.UseVisualStyleBackColor = true;
            button_verpedido.Click += button_verpedido_Click;
            // 
            // button_sacarPedido
            // 
            button_sacarPedido.Location = new Point(12, 411);
            button_sacarPedido.Name = "button_sacarPedido";
            button_sacarPedido.Size = new Size(210, 52);
            button_sacarPedido.TabIndex = 5;
            button_sacarPedido.Text = "Sacar Pedido";
            button_sacarPedido.UseVisualStyleBackColor = true;
            button_sacarPedido.Click += button_sacarPedido_Click;
            // 
            // FormCocina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1523, 913);
            Controls.Add(button_sacarPedido);
            Controls.Add(button_verpedido);
            Controls.Add(dataGridView2);
            Controls.Add(label_producto);
            Controls.Add(label_pedido);
            Controls.Add(dataGridView1);
            Name = "FormCocina";
            Text = "FormCocina";
            Load += FormCocina_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label_pedido;
        private Label label_producto;
        private DataGridView dataGridView2;
        private Button button_verpedido;
        private Button button_sacarPedido;
    }
}