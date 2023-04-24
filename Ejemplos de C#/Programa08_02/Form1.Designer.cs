namespace Programa08_02
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
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.rbtManzana = new System.Windows.Forms.RadioButton();
            this.rbtPera = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkImportado = new System.Windows.Forms.CheckBox();
            this.chkOrganico = new System.Windows.Forms.CheckBox();
            this.rbtCiruela = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmensaje
            // 
            this.txtmensaje.Location = new System.Drawing.Point(18, 30);
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(160, 23);
            this.txtmensaje.TabIndex = 0;
            // 
            // rbtManzana
            // 
            this.rbtManzana.AutoSize = true;
            this.rbtManzana.Checked = true;
            this.rbtManzana.Location = new System.Drawing.Point(6, 35);
            this.rbtManzana.Name = "rbtManzana";
            this.rbtManzana.Size = new System.Drawing.Size(73, 19);
            this.rbtManzana.TabIndex = 2;
            this.rbtManzana.TabStop = true;
            this.rbtManzana.Text = "Manzana";
            this.rbtManzana.UseVisualStyleBackColor = true;
            // 
            // rbtPera
            // 
            this.rbtPera.AutoSize = true;
            this.rbtPera.Location = new System.Drawing.Point(6, 84);
            this.rbtPera.Name = "rbtPera";
            this.rbtPera.Size = new System.Drawing.Size(48, 19);
            this.rbtPera.TabIndex = 3;
            this.rbtPera.Text = "Pera";
            this.rbtPera.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtCiruela);
            this.groupBox1.Controls.Add(this.rbtManzana);
            this.groupBox1.Controls.Add(this.rbtPera);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 191);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chkImportado
            // 
            this.chkImportado.AutoSize = true;
            this.chkImportado.Location = new System.Drawing.Point(341, 98);
            this.chkImportado.Name = "chkImportado";
            this.chkImportado.Size = new System.Drawing.Size(82, 19);
            this.chkImportado.TabIndex = 8;
            this.chkImportado.Text = "Importado";
            this.chkImportado.UseVisualStyleBackColor = true;
            // 
            // chkOrganico
            // 
            this.chkOrganico.AutoSize = true;
            this.chkOrganico.Location = new System.Drawing.Point(341, 163);
            this.chkOrganico.Name = "chkOrganico";
            this.chkOrganico.Size = new System.Drawing.Size(75, 19);
            this.chkOrganico.TabIndex = 9;
            this.chkOrganico.Text = "Organico";
            this.chkOrganico.UseVisualStyleBackColor = true;
            // 
            // rbtCiruela
            // 
            this.rbtCiruela.AutoSize = true;
            this.rbtCiruela.Location = new System.Drawing.Point(6, 141);
            this.rbtCiruela.Name = "rbtCiruela";
            this.rbtCiruela.Size = new System.Drawing.Size(62, 19);
            this.rbtCiruela.TabIndex = 4;
            this.rbtCiruela.Text = "Ciruela";
            this.rbtCiruela.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 297);
            this.Controls.Add(this.chkOrganico);
            this.Controls.Add(this.chkImportado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtmensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtmensaje;
        private RadioButton rbtManzana;
        private RadioButton rbtPera;
        private GroupBox groupBox1;
        private RadioButton rbtCiruela;
        private CheckBox chkImportado;
        private CheckBox chkOrganico;
    }
}