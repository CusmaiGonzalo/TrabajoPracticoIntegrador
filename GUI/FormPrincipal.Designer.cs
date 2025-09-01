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
            uSUARIOSToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(1133, 725);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(158, 31);
            buttonLogout.TabIndex = 1;
            buttonLogout.Text = "Log Out";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { uSUARIOSToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1303, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            uSUARIOSToolStripMenuItem.Size = new Size(74, 20);
            uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            uSUARIOSToolStripMenuItem.Click += uSUARIOSToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 768);
            Controls.Add(buttonLogout);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogout;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem uSUARIOSToolStripMenuItem;
    }
}