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
            iDIOMASToolStripMenuItem = new ToolStripMenuItem();
            pRODUCTOSToolStripMenuItem = new ToolStripMenuItem();
            eSTADOTABLASToolStripMenuItem = new ToolStripMenuItem();
            vENTASToolStripMenuItem = new ToolStripMenuItem();
            cOCINAToolStripMenuItem = new ToolStripMenuItem();
            dESPACHOToolStripMenuItem = new ToolStripMenuItem();
            button_cambiaridioma = new Button();
            comboBox_idioma = new ComboBox();
            sUPERVISORToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(1495, 698);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(158, 31);
            buttonLogout.TabIndex = 1;
            buttonLogout.Text = "Cerrar Sesión";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem, uSUARIOSToolStripMenuItem, eVENTOSToolStripMenuItem, iDIOMASToolStripMenuItem, pRODUCTOSToolStripMenuItem, eSTADOTABLASToolStripMenuItem, vENTASToolStripMenuItem, cOCINAToolStripMenuItem, dESPACHOToolStripMenuItem, sUPERVISORToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1684, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size = new Size(54, 20);
            iNICIOToolStripMenuItem.Text = "INICIO";
            iNICIOToolStripMenuItem.Click += iNICIOToolStripMenuItem_Click;
            // 
            // uSUARIOSToolStripMenuItem
            // 
            uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            uSUARIOSToolStripMenuItem.Size = new Size(74, 20);
            uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            uSUARIOSToolStripMenuItem.Click += uSUARIOSToolStripMenuItem_Click;
            // 
            // eVENTOSToolStripMenuItem
            // 
            eVENTOSToolStripMenuItem.Name = "eVENTOSToolStripMenuItem";
            eVENTOSToolStripMenuItem.Size = new Size(67, 20);
            eVENTOSToolStripMenuItem.Text = "EVENTOS";
            eVENTOSToolStripMenuItem.Click += eVENTOSToolStripMenuItem_Click;
            // 
            // iDIOMASToolStripMenuItem
            // 
            iDIOMASToolStripMenuItem.Name = "iDIOMASToolStripMenuItem";
            iDIOMASToolStripMenuItem.Size = new Size(67, 20);
            iDIOMASToolStripMenuItem.Text = "IDIOMAS";
            iDIOMASToolStripMenuItem.Click += iDIOMASToolStripMenuItem_Click;
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            pRODUCTOSToolStripMenuItem.Size = new Size(86, 20);
            pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS";
            pRODUCTOSToolStripMenuItem.Click += pRODUCTOSToolStripMenuItem_Click;
            // 
            // eSTADOTABLASToolStripMenuItem
            // 
            eSTADOTABLASToolStripMenuItem.Name = "eSTADOTABLASToolStripMenuItem";
            eSTADOTABLASToolStripMenuItem.Size = new Size(104, 20);
            eSTADOTABLASToolStripMenuItem.Text = "ESTADO TABLAS";
            eSTADOTABLASToolStripMenuItem.Click += eSTADOTABLASToolStripMenuItem_Click;
            // 
            // vENTASToolStripMenuItem
            // 
            vENTASToolStripMenuItem.Name = "vENTASToolStripMenuItem";
            vENTASToolStripMenuItem.Size = new Size(60, 20);
            vENTASToolStripMenuItem.Text = "VENTAS";
            vENTASToolStripMenuItem.Click += vENTASToolStripMenuItem_Click;
            // 
            // cOCINAToolStripMenuItem
            // 
            cOCINAToolStripMenuItem.Name = "cOCINAToolStripMenuItem";
            cOCINAToolStripMenuItem.Size = new Size(64, 20);
            cOCINAToolStripMenuItem.Text = "COCINA";
            cOCINAToolStripMenuItem.Click += cOCINAToolStripMenuItem_Click;
            // 
            // dESPACHOToolStripMenuItem
            // 
            dESPACHOToolStripMenuItem.Name = "dESPACHOToolStripMenuItem";
            dESPACHOToolStripMenuItem.Size = new Size(79, 20);
            dESPACHOToolStripMenuItem.Text = "DESPACHO";
            dESPACHOToolStripMenuItem.Click += dESPACHOToolStripMenuItem_Click;
            // 
            // button_cambiaridioma
            // 
            button_cambiaridioma.Location = new Point(1494, 42);
            button_cambiaridioma.Name = "button_cambiaridioma";
            button_cambiaridioma.Size = new Size(158, 31);
            button_cambiaridioma.TabIndex = 5;
            button_cambiaridioma.Text = "Cambiar Idioma";
            button_cambiaridioma.UseVisualStyleBackColor = true;
            button_cambiaridioma.Click += button_cambiaridioma_Click;
            // 
            // comboBox_idioma
            // 
            comboBox_idioma.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_idioma.FormattingEnabled = true;
            comboBox_idioma.Location = new Point(1494, 78);
            comboBox_idioma.Margin = new Padding(3, 2, 3, 2);
            comboBox_idioma.Name = "comboBox_idioma";
            comboBox_idioma.Size = new Size(158, 23);
            comboBox_idioma.TabIndex = 6;
            // 
            // sUPERVISORToolStripMenuItem
            // 
            sUPERVISORToolStripMenuItem.Name = "sUPERVISORToolStripMenuItem";
            sUPERVISORToolStripMenuItem.Size = new Size(85, 20);
            sUPERVISORToolStripMenuItem.Text = "SUPERVISOR";
            sUPERVISORToolStripMenuItem.Click += sUPERVISORToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1684, 791);
            Controls.Add(comboBox_idioma);
            Controls.Add(button_cambiaridioma);
            Controls.Add(buttonLogout);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            WindowState = FormWindowState.Maximized;
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
        private ToolStripMenuItem iDIOMASToolStripMenuItem;
        private ToolStripMenuItem eSTADOTABLASToolStripMenuItem;
        private ToolStripMenuItem vENTASToolStripMenuItem;
        private ToolStripMenuItem cOCINAToolStripMenuItem;
        private ToolStripMenuItem dESPACHOToolStripMenuItem;
        private ToolStripMenuItem sUPERVISORToolStripMenuItem;
    }
}