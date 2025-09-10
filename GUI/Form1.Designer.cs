namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textbox_nombreus = new TextBox();
            labelUsuario = new Label();
            textBoxContraseña = new TextBox();
            labelcontraseña = new Label();
            buttonLogin = new Button();
            labelIntentos = new Label();
            SuspendLayout();
            // 
            // textbox_nombreus
            // 
            textbox_nombreus.Location = new Point(14, 36);
            textbox_nombreus.Margin = new Padding(3, 4, 3, 4);
            textbox_nombreus.Name = "textbox_nombreus";
            textbox_nombreus.Size = new Size(380, 27);
            textbox_nombreus.TabIndex = 0;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(14, 12);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(59, 20);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Usuario";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(14, 95);
            textBoxContraseña.Margin = new Padding(3, 4, 3, 4);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(380, 27);
            textBoxContraseña.TabIndex = 2;
            // 
            // labelcontraseña
            // 
            labelcontraseña.AutoSize = true;
            labelcontraseña.Location = new Point(14, 71);
            labelcontraseña.Name = "labelcontraseña";
            labelcontraseña.Size = new Size(83, 20);
            labelcontraseña.TabIndex = 3;
            labelcontraseña.Text = "Contraseña";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(14, 130);
            buttonLogin.Margin = new Padding(3, 4, 3, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(380, 77);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Log In";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelIntentos
            // 
            labelIntentos.AutoSize = true;
            labelIntentos.ForeColor = Color.Red;
            labelIntentos.Location = new Point(14, 214);
            labelIntentos.Name = "labelIntentos";
            labelIntentos.Size = new Size(0, 20);
            labelIntentos.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 257);
            Controls.Add(labelIntentos);
            Controls.Add(buttonLogin);
            Controls.Add(labelcontraseña);
            Controls.Add(textBoxContraseña);
            Controls.Add(labelUsuario);
            Controls.Add(textbox_nombreus);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Inicio de Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textbox_nombreus;
        private Label labelUsuario;
        private TextBox textBoxContraseña;
        private Label labelcontraseña;
        private Button buttonLogin;
        private Label labelIntentos;
    }
}
