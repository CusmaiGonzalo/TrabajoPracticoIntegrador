namespace GUI
{
    partial class FormInicio
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
            label_bienvenido = new Label();
            label_sistema = new Label();
            SuspendLayout();
            // 
            // label_bienvenido
            // 
            label_bienvenido.AutoSize = true;
            label_bienvenido.Location = new Point(12, 9);
            label_bienvenido.Name = "label_bienvenido";
            label_bienvenido.Size = new Size(87, 20);
            label_bienvenido.TabIndex = 0;
            label_bienvenido.Text = "Bienvenido ";
            // 
            // label_sistema
            // 
            label_sistema.AutoSize = true;
            label_sistema.Location = new Point(12, 29);
            label_sistema.Name = "label_sistema";
            label_sistema.Size = new Size(50, 20);
            label_sistema.TabIndex = 1;
            label_sistema.Text = "label1";
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 581);
            Controls.Add(label_sistema);
            Controls.Add(label_bienvenido);
            Name = "FormInicio";
            Text = "FormInicio";
            Load += FormInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_bienvenido;
        private Label label_sistema;
    }
}