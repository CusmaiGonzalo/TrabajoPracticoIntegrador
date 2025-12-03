namespace GUI
{
    partial class FormEstadoTablas
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
            textBox1 = new TextBox();
            label_dvv = new Label();
            label_estadotabladvh = new Label();
            button_recalctabla = new Button();
            button_realizarbackup = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button_realizarrestore = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(248, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1023, 504);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 562);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 27);
            textBox1.TabIndex = 1;
            // 
            // label_dvv
            // 
            label_dvv.AutoSize = true;
            label_dvv.Location = new Point(248, 539);
            label_dvv.Name = "label_dvv";
            label_dvv.Size = new Size(50, 20);
            label_dvv.TabIndex = 2;
            label_dvv.Text = "label1";
            // 
            // label_estadotabladvh
            // 
            label_estadotabladvh.AutoSize = true;
            label_estadotabladvh.Location = new Point(248, 9);
            label_estadotabladvh.Name = "label_estadotabladvh";
            label_estadotabladvh.Size = new Size(127, 20);
            label_estadotabladvh.TabIndex = 3;
            label_estadotabladvh.Text = "label_estadotabla";
            // 
            // button_recalctabla
            // 
            button_recalctabla.Location = new Point(12, 32);
            button_recalctabla.Name = "button_recalctabla";
            button_recalctabla.Size = new Size(230, 57);
            button_recalctabla.TabIndex = 4;
            button_recalctabla.Text = "Recalcular Tablas";
            button_recalctabla.UseVisualStyleBackColor = true;
            button_recalctabla.Click += button_recalctabla_Click;
            // 
            // button_realizarbackup
            // 
            button_realizarbackup.Location = new Point(1277, 32);
            button_realizarbackup.Name = "button_realizarbackup";
            button_realizarbackup.Size = new Size(376, 57);
            button_realizarbackup.TabIndex = 5;
            button_realizarbackup.Text = "Realizar BACKUP";
            button_realizarbackup.UseVisualStyleBackColor = true;
            button_realizarbackup.Click += button_realizarbackup_Click;
            // 
            // button_realizarrestore
            // 
            button_realizarrestore.Location = new Point(1277, 95);
            button_realizarrestore.Name = "button_realizarrestore";
            button_realizarrestore.Size = new Size(376, 57);
            button_realizarrestore.TabIndex = 6;
            button_realizarrestore.Text = "Realizar RESTORE";
            button_realizarrestore.UseVisualStyleBackColor = true;
            button_realizarrestore.Click += button_realizarrestore_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormEstadoTablas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 806);
            Controls.Add(button_realizarrestore);
            Controls.Add(button_realizarbackup);
            Controls.Add(button_recalctabla);
            Controls.Add(label_estadotabladvh);
            Controls.Add(label_dvv);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "FormEstadoTablas";
            Text = "FormEstadoTablas";
            Load += FormEstadoTablas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label_dvv;
        private Label label_estadotabladvh;
        private Button button_recalctabla;
        private Button button_realizarbackup;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button_realizarrestore;
        private OpenFileDialog openFileDialog1;
    }
}