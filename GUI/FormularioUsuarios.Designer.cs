namespace GUI
{
    partial class FormularioUsuarios
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label_usuarioINS = new Label();
            label_contINS = new Label();
            button_agregarUs = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 36);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 95);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 27);
            textBox2.TabIndex = 1;
            // 
            // label_usuarioINS
            // 
            label_usuarioINS.AutoSize = true;
            label_usuarioINS.Location = new Point(14, 12);
            label_usuarioINS.Name = "label_usuarioINS";
            label_usuarioINS.Size = new Size(59, 20);
            label_usuarioINS.TabIndex = 2;
            label_usuarioINS.Text = "Usuario";
            // 
            // label_contINS
            // 
            label_contINS.AutoSize = true;
            label_contINS.Location = new Point(14, 71);
            label_contINS.Name = "label_contINS";
            label_contINS.Size = new Size(83, 20);
            label_contINS.TabIndex = 3;
            label_contINS.Text = "Contraseña";
            // 
            // button_agregarUs
            // 
            button_agregarUs.Location = new Point(14, 133);
            button_agregarUs.Margin = new Padding(3, 4, 3, 4);
            button_agregarUs.Name = "button_agregarUs";
            button_agregarUs.Size = new Size(233, 41);
            button_agregarUs.TabIndex = 4;
            button_agregarUs.Text = "Agregar Usuario";
            button_agregarUs.UseVisualStyleBackColor = true;
            button_agregarUs.Click += button1_Click;
            // 
            // FormularioUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1446, 1055);
            Controls.Add(button_agregarUs);
            Controls.Add(label_contINS);
            Controls.Add(label_usuarioINS);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormularioUsuarios";
            Text = "FormularioUsuarios";
            Load += FormularioUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label_usuarioINS;
        private Label label_contINS;
        private Button button_agregarUs;
    }
}