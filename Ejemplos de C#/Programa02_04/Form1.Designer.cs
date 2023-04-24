namespace _9
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.rbnBasico = new System.Windows.Forms.RadioButton();
            this.rbnTerceros = new System.Windows.Forms.RadioButton();
            this.rbnTotal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.chkAire = new System.Windows.Forms.CheckBox();
            this.chkAudio = new System.Windows.Forms.CheckBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.txtCotizacion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(66, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblSeguro
            // 
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.Location = new System.Drawing.Point(6, 16);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(44, 13);
            this.lblSeguro.TabIndex = 2;
            this.lblSeguro.Text = "Seguro:";
            // 
            // rbnBasico
            // 
            this.rbnBasico.AutoSize = true;
            this.rbnBasico.Checked = true;
            this.rbnBasico.Location = new System.Drawing.Point(56, 33);
            this.rbnBasico.Name = "rbnBasico";
            this.rbnBasico.Size = new System.Drawing.Size(57, 17);
            this.rbnBasico.TabIndex = 3;
            this.rbnBasico.TabStop = true;
            this.rbnBasico.Text = "Basico";
            this.rbnBasico.UseVisualStyleBackColor = true;
            // 
            // rbnTerceros
            // 
            this.rbnTerceros.AutoSize = true;
            this.rbnTerceros.Location = new System.Drawing.Point(56, 57);
            this.rbnTerceros.Name = "rbnTerceros";
            this.rbnTerceros.Size = new System.Drawing.Size(77, 17);
            this.rbnTerceros.TabIndex = 4;
            this.rbnTerceros.Text = "A Terceros";
            this.rbnTerceros.UseVisualStyleBackColor = true;
            // 
            // rbnTotal
            // 
            this.rbnTotal.AutoSize = true;
            this.rbnTotal.Location = new System.Drawing.Point(56, 81);
            this.rbnTotal.Name = "rbnTotal";
            this.rbnTotal.Size = new System.Drawing.Size(49, 17);
            this.rbnTotal.TabIndex = 5;
            this.rbnTotal.Text = "Total";
            this.rbnTotal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSeguro);
            this.groupBox1.Controls.Add(this.rbnTotal);
            this.groupBox1.Controls.Add(this.rbnBasico);
            this.groupBox1.Controls.Add(this.rbnTerceros);
            this.groupBox1.Location = new System.Drawing.Point(19, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seguros a seleccionar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAudio);
            this.groupBox2.Controls.Add(this.chkAire);
            this.groupBox2.Controls.Add(this.lblEquipo);
            this.groupBox2.Location = new System.Drawing.Point(187, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 113);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipamiento";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(6, 16);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(43, 13);
            this.lblEquipo.TabIndex = 0;
            this.lblEquipo.Text = "Equipo:";
            // 
            // chkAire
            // 
            this.chkAire.AutoSize = true;
            this.chkAire.Location = new System.Drawing.Point(50, 33);
            this.chkAire.Name = "chkAire";
            this.chkAire.Size = new System.Drawing.Size(117, 17);
            this.chkAire.TabIndex = 1;
            this.chkAire.Text = "Aire acondicionado";
            this.chkAire.UseVisualStyleBackColor = true;
            // 
            // chkAudio
            // 
            this.chkAudio.AutoSize = true;
            this.chkAudio.Location = new System.Drawing.Point(50, 58);
            this.chkAudio.Name = "chkAudio";
            this.chkAudio.Size = new System.Drawing.Size(108, 17);
            this.chkAudio.TabIndex = 2;
            this.chkAudio.Text = "Sistema de Audio";
            this.chkAudio.UseVisualStyleBackColor = true;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(25, 185);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(37, 13);
            this.lblCosto.TabIndex = 8;
            this.lblCosto.Text = "Costo:";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(65, 182);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 9;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(187, 180);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(75, 23);
            this.btnCotizar.TabIndex = 10;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // txtCotizacion
            // 
            this.txtCotizacion.Location = new System.Drawing.Point(52, 208);
            this.txtCotizacion.Multiline = true;
            this.txtCotizacion.Name = "txtCotizacion";
            this.txtCotizacion.Size = new System.Drawing.Size(293, 84);
            this.txtCotizacion.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 314);
            this.Controls.Add(this.txtCotizacion);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.RadioButton rbnBasico;
        private System.Windows.Forms.RadioButton rbnTerceros;
        private System.Windows.Forms.RadioButton rbnTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.CheckBox chkAudio;
        private System.Windows.Forms.CheckBox chkAire;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.TextBox txtCotizacion;
    }
}

