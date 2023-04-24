namespace Programa08_05
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarVentan1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarVentana2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarVentan1ToolStripMenuItem,
            this.adicionarVentana2ToolStripMenuItem});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // adicionarVentan1ToolStripMenuItem
            // 
            this.adicionarVentan1ToolStripMenuItem.Name = "adicionarVentan1ToolStripMenuItem";
            this.adicionarVentan1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarVentan1ToolStripMenuItem.Text = "Adicionar Ventana 1";
            this.adicionarVentan1ToolStripMenuItem.Click += new System.EventHandler(this.adicionarVentan1ToolStripMenuItem_Click);
            // 
            // adicionarVentana2ToolStripMenuItem
            // 
            this.adicionarVentana2ToolStripMenuItem.Name = "adicionarVentana2ToolStripMenuItem";
            this.adicionarVentana2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adicionarVentana2ToolStripMenuItem.Text = "Adicionar Ventana 2";
            this.adicionarVentana2ToolStripMenuItem.Click += new System.EventHandler(this.adicionarVentana2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 373);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarVentan1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarVentana2ToolStripMenuItem;
    }
}

