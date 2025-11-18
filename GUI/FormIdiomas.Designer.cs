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
            label_etiquetasytrad = new Label();
            comboBox1 = new ComboBox();
            label_idiomasdispon = new Label();
            button_selIdioma = new Button();
            textBox1 = new TextBox();
            label_nombreidiomanue = new Label();
            button_agregaridioma = new Button();
            button_modtrad = new Button();
            textBox_idiomaselec = new TextBox();
            button_altaidi = new Button();
            label_idiomaselec = new Label();
            button_borraridioma = new Button();
            button_bajaidioma = new Button();
            button_modnomid = new Button();
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
            // label_etiquetasytrad
            // 
            label_etiquetasytrad.AutoSize = true;
            label_etiquetasytrad.Location = new Point(270, 9);
            label_etiquetasytrad.Name = "label_etiquetasytrad";
            label_etiquetasytrad.Size = new Size(50, 20);
            label_etiquetasytrad.TabIndex = 1;
            label_etiquetasytrad.Text = "label1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 28);
            comboBox1.TabIndex = 2;
            // 
            // label_idiomasdispon
            // 
            label_idiomasdispon.AutoSize = true;
            label_idiomasdispon.Location = new Point(12, 32);
            label_idiomasdispon.Name = "label_idiomasdispon";
            label_idiomasdispon.Size = new Size(50, 20);
            label_idiomasdispon.TabIndex = 3;
            label_idiomasdispon.Text = "label2";
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
            // label_nombreidiomanue
            // 
            label_nombreidiomanue.AutoSize = true;
            label_nombreidiomanue.Location = new Point(12, 128);
            label_nombreidiomanue.Name = "label_nombreidiomanue";
            label_nombreidiomanue.Size = new Size(50, 20);
            label_nombreidiomanue.TabIndex = 6;
            label_nombreidiomanue.Text = "label3";
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
            // button_modtrad
            // 
            button_modtrad.Location = new Point(12, 268);
            button_modtrad.Name = "button_modtrad";
            button_modtrad.Size = new Size(252, 36);
            button_modtrad.TabIndex = 8;
            button_modtrad.Text = "Modificar Traduccion";
            button_modtrad.UseVisualStyleBackColor = true;
            button_modtrad.Click += button_modtrad_Click;
            // 
            // textBox_idiomaselec
            // 
            textBox_idiomaselec.Location = new Point(12, 330);
            textBox_idiomaselec.Name = "textBox_idiomaselec";
            textBox_idiomaselec.Size = new Size(252, 27);
            textBox_idiomaselec.TabIndex = 9;
            // 
            // button_altaidi
            // 
            button_altaidi.Location = new Point(12, 363);
            button_altaidi.Name = "button_altaidi";
            button_altaidi.Size = new Size(252, 36);
            button_altaidi.TabIndex = 10;
            button_altaidi.Text = "Alta de Idioma";
            button_altaidi.UseVisualStyleBackColor = true;
            button_altaidi.Click += button_altaidi_Click;
            // 
            // label_idiomaselec
            // 
            label_idiomaselec.AutoSize = true;
            label_idiomaselec.Location = new Point(12, 307);
            label_idiomaselec.Name = "label_idiomaselec";
            label_idiomaselec.Size = new Size(50, 20);
            label_idiomaselec.TabIndex = 11;
            label_idiomaselec.Text = "label4";
            // 
            // button_borraridioma
            // 
            button_borraridioma.Location = new Point(12, 226);
            button_borraridioma.Name = "button_borraridioma";
            button_borraridioma.Size = new Size(252, 36);
            button_borraridioma.TabIndex = 12;
            button_borraridioma.Text = "Borrar Idioma";
            button_borraridioma.UseVisualStyleBackColor = true;
            button_borraridioma.Click += button_borraridioma_Click;
            // 
            // button_bajaidioma
            // 
            button_bajaidioma.Location = new Point(12, 405);
            button_bajaidioma.Name = "button_bajaidioma";
            button_bajaidioma.Size = new Size(252, 36);
            button_bajaidioma.TabIndex = 13;
            button_bajaidioma.Text = "Baja de Idioma";
            button_bajaidioma.UseVisualStyleBackColor = true;
            button_bajaidioma.Click += button_bajaidioma_Click;
            // 
            // button_modnomid
            // 
            button_modnomid.Location = new Point(12, 447);
            button_modnomid.Name = "button_modnomid";
            button_modnomid.Size = new Size(252, 36);
            button_modnomid.TabIndex = 14;
            button_modnomid.Text = "Modificar Nombre Idioma";
            button_modnomid.UseVisualStyleBackColor = true;
            button_modnomid.Click += button_modnomid_Click;
            // 
            // FormIdiomas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 681);
            Controls.Add(button_modnomid);
            Controls.Add(button_bajaidioma);
            Controls.Add(button_borraridioma);
            Controls.Add(label_idiomaselec);
            Controls.Add(button_altaidi);
            Controls.Add(textBox_idiomaselec);
            Controls.Add(button_modtrad);
            Controls.Add(button_agregaridioma);
            Controls.Add(label_nombreidiomanue);
            Controls.Add(textBox1);
            Controls.Add(button_selIdioma);
            Controls.Add(label_idiomasdispon);
            Controls.Add(comboBox1);
            Controls.Add(label_etiquetasytrad);
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
        private Label label_etiquetasytrad;
        private ComboBox comboBox1;
        private Label label_idiomasdispon;
        private Button button_selIdioma;
        private TextBox textBox1;
        private Label label_nombreidiomanue;
        private Button button_agregaridioma;
        private Button button_modtrad;
        private TextBox textBox_idiomaselec;
        private Button button_altaidi;
        private Label label_idiomaselec;
        private Button button_borraridioma;
        private Button button_bajaidioma;
        private Button button_modnomid;
    }
}