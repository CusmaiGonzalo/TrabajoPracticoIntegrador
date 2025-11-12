namespace GUI
{
    partial class FormIdiomas
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            button_selIdioma = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            button_agregaridioma = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(270, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(973, 494);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 28);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 32);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // button_selIdioma
            // 
            button_selIdioma.Location = new Point(12, 89);
            button_selIdioma.Name = "button_selIdioma";
            button_selIdioma.Size = new Size(252, 36);
            button_selIdioma.TabIndex = 4;
            button_selIdioma.Text = "Seleccionar Idioma";
            button_selIdioma.UseVisualStyleBackColor = true;
            button_selIdioma.Click += button_selIdioma_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 27);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // button_agregaridioma
            // 
            button_agregaridioma.Location = new Point(12, 184);
            button_agregaridioma.Name = "button_agregaridioma";
            button_agregaridioma.Size = new Size(252, 36);
            button_agregaridioma.TabIndex = 7;
            button_agregaridioma.Text = "Agregar Idioma";
            button_agregaridioma.UseVisualStyleBackColor = true;
            button_agregaridioma.Click += button_agregaridioma_Click;
            // 
            // FormIdiomas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 681);
            Controls.Add(button_agregaridioma);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button_selIdioma);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormIdiomas";
            Text = "FormIdiomas";
            Load += FormIdiomas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Button button_selIdioma;
        private TextBox textBox1;
        private Label label3;
        private Button button_agregaridioma;
    }
}