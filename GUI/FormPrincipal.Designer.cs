namespace GUI
{
    partial class FormPrincipal
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
            buttonLogout = new Button();
            menuStrip1 = new MenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            uSUARIOSToolStripMenuItem = new ToolStripMenuItem();
            eVENTOSToolStripMenuItem = new ToolStripMenuItem();
            pRODUCTOSToolStripMenuItem = new ToolStripMenuItem();
            button_cambiaridioma = new Button();
            comboBox_idioma = new ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(1295, 967);
            buttonLogout.Margin = new Padding(3, 4, 3, 4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(181, 41);
            buttonLogout.TabIndex = 1;
            buttonLogout.Text = "Cerrar Sesión";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem, uSUARIOSToolStripMenuItem, eVENTOSToolStripMenuItem, pRODUCTOSToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1489, 30);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size = new Size(66, 24);
            iNICIOToolStripMenuItem.Text = "INICIO";
            iNICIOToolStripMenuItem.Click += iNICIOToolStripMenuItem_Click;
            // 
            // uSUARIOSToolStripMenuItem
            // 
            uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            uSUARIOSToolStripMenuItem.Size = new Size(93, 24);
            uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            uSUARIOSToolStripMenuItem.Click += uSUARIOSToolStripMenuItem_Click;
            // 
            // eVENTOSToolStripMenuItem
            // 
            eVENTOSToolStripMenuItem.Name = "eVENTOSToolStripMenuItem";
            eVENTOSToolStripMenuItem.Size = new Size(85, 24);
            eVENTOSToolStripMenuItem.Text = "EVENTOS";
            eVENTOSToolStripMenuItem.Click += eVENTOSToolStripMenuItem_Click;
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            pRODUCTOSToolStripMenuItem.Size = new Size(107, 24);
            pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS";
            pRODUCTOSToolStripMenuItem.Click += pRODUCTOSToolStripMenuItem_Click;
            // 
            // button_cambiaridioma
            // 
            button_cambiaridioma.Location = new Point(1296, 44);
            button_cambiaridioma.Margin = new Padding(3, 4, 3, 4);
            button_cambiaridioma.Name = "button_cambiaridioma";
            button_cambiaridioma.Size = new Size(181, 41);
            button_cambiaridioma.TabIndex = 5;
            button_cambiaridioma.Text = "Cambiar Idioma";
            button_cambiaridioma.UseVisualStyleBackColor = true;
            button_cambiaridioma.Click += button_cambiaridioma_Click;
            // 
            // comboBox_idioma
            // 
            comboBox_idioma.FormattingEnabled = true;
            comboBox_idioma.Location = new Point(1296, 92);
            comboBox_idioma.Name = "comboBox_idioma";
            comboBox_idioma.Size = new Size(180, 28);
            comboBox_idioma.TabIndex = 6;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 1024);
            Controls.Add(comboBox_idioma);
            Controls.Add(button_cambiaridioma);
            Controls.Add(buttonLogout);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogout;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private ToolStripMenuItem eVENTOSToolStripMenuItem;
        private ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private Button button_cambiaridioma;
        private ComboBox comboBox_idioma;
    }
}