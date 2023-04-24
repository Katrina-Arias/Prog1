namespace Programa08_01
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
            this.components = new System.ComponentModel.Container();
            this.btnAbrirNotePad = new System.Windows.Forms.Button();
            this.btnCerrarNotePad = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.prcNotePad = new System.Diagnostics.Process();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esconderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrirNotePad
            // 
            this.btnAbrirNotePad.Location = new System.Drawing.Point(198, 51);
            this.btnAbrirNotePad.Name = "btnAbrirNotePad";
            this.btnAbrirNotePad.Size = new System.Drawing.Size(109, 23);
            this.btnAbrirNotePad.TabIndex = 0;
            this.btnAbrirNotePad.Text = "Abrir Notepad";
            this.btnAbrirNotePad.UseVisualStyleBackColor = true;
            this.btnAbrirNotePad.Click += new System.EventHandler(this.btnAbrirNotePad_Click);
            // 
            // btnCerrarNotePad
            // 
            this.btnCerrarNotePad.Location = new System.Drawing.Point(198, 120);
            this.btnCerrarNotePad.Name = "btnCerrarNotePad";
            this.btnCerrarNotePad.Size = new System.Drawing.Size(109, 23);
            this.btnCerrarNotePad.TabIndex = 1;
            this.btnCerrarNotePad.Text = "Cerrar Notepad";
            this.btnCerrarNotePad.UseVisualStyleBackColor = true;
            this.btnCerrarNotePad.Click += new System.EventHandler(this.btnCerrarNotePad_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(49, 59);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 15);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Esperando";
            // 
            // prcNotePad
            // 
            this.prcNotePad.StartInfo.Domain = "";
            this.prcNotePad.StartInfo.FileName = "notepad.exe";
            this.prcNotePad.StartInfo.LoadUserProfile = false;
            this.prcNotePad.StartInfo.Password = null;
            this.prcNotePad.StartInfo.StandardErrorEncoding = null;
            this.prcNotePad.StartInfo.StandardInputEncoding = null;
            this.prcNotePad.StartInfo.StandardOutputEncoding = null;
            this.prcNotePad.StartInfo.UserName = "";
            this.prcNotePad.StartInfo.WorkingDirectory = "%system%\\system32";
            this.prcNotePad.SynchronizingObject = this;
            this.prcNotePad.Exited += new System.EventHandler(this.prcNotePad_Exited);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.esconderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // esconderToolStripMenuItem
            // 
            this.esconderToolStripMenuItem.Name = "esconderToolStripMenuItem";
            this.esconderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.esconderToolStripMenuItem.Text = "Esconder";
            this.esconderToolStripMenuItem.Click += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "Abre Aplicaciones";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 286);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnCerrarNotePad);
            this.Controls.Add(this.btnAbrirNotePad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAbrirNotePad;
        private Button btnCerrarNotePad;
        private Label lblEstado;
        private System.Diagnostics.Process prcNotePad;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mostrarToolStripMenuItem;
        private ToolStripMenuItem esconderToolStripMenuItem;
        private NotifyIcon notifyIcon1;
    }
}