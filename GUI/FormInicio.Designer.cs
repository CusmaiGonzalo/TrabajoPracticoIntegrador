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
            label_usuario = new Label();
            label_status = new Label();
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
            label_sistema.Size = new Size(206, 20);
            label_sistema.TabIndex = 1;
            label_sistema.Text = "Sistema Gestión de Negocios.";
            // 
            // label_usuario
            // 
            label_usuario.AutoSize = true;
            label_usuario.Location = new Point(121, 9);
            label_usuario.Name = "label_usuario";
            label_usuario.Size = new Size(0, 20);
            label_usuario.TabIndex = 2;
            // 
            // label_status
            // 
            label_status.AutoSize = true;
            label_status.Location = new Point(12, 49);
            label_status.Name = "label_status";
            label_status.Size = new Size(296, 20);
            label_status.TabIndex = 3;
            label_status.Text = "El sistema esta funcionando correctamente.";
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 581);
            Controls.Add(label_status);
            Controls.Add(label_usuario);
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
        private Label label_usuario;
        private Label label_status;
    }
}