namespace GUI
{
    partial class FormDespacho
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
            label_paraentregar = new Label();
            dataGridView1 = new DataGridView();
            button_entregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_paraentregar
            // 
            label_paraentregar.AutoSize = true;
            label_paraentregar.Location = new Point(193, 9);
            label_paraentregar.Name = "label_paraentregar";
            label_paraentregar.Size = new Size(99, 15);
            label_paraentregar.TabIndex = 0;
            label_paraentregar.Text = "PARA ENTREGAR:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(193, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(842, 433);
            dataGridView1.TabIndex = 1;
            // 
            // button_entregar
            // 
            button_entregar.Location = new Point(12, 27);
            button_entregar.Name = "button_entregar";
            button_entregar.Size = new Size(175, 51);
            button_entregar.TabIndex = 2;
            button_entregar.Text = "Entregar";
            button_entregar.UseVisualStyleBackColor = true;
            button_entregar.Click += button_entregar_Click;
            // 
            // FormDespacho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1476, 797);
            Controls.Add(button_entregar);
            Controls.Add(dataGridView1);
            Controls.Add(label_paraentregar);
            Name = "FormDespacho";
            Text = "FormDespacho";
            Load += FormDespacho_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_paraentregar;
        private DataGridView dataGridView1;
        private Button button_entregar;
    }
}