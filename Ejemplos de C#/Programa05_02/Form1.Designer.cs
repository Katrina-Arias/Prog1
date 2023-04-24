namespace Programa05_02
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
            cmbAlimentos = new ComboBox();
            txtAlimento = new TextBox();
            btnAdicionar = new Button();
            lblIndice = new Label();
            lblTexto = new Label();
            SuspendLayout();
            // 
            // cmbAlimentos
            // 
            cmbAlimentos.FormattingEnabled = true;
            cmbAlimentos.Items.AddRange(new object[] { "Frijol", "Tomate" });
            cmbAlimentos.Location = new Point(90, 64);
            cmbAlimentos.Name = "cmbAlimentos";
            cmbAlimentos.Size = new Size(151, 28);
            cmbAlimentos.TabIndex = 0;
            cmbAlimentos.Text = "Alimentos";
            cmbAlimentos.SelectedIndexChanged += cmbAlimentos_SelectedIndexChanged;
            // 
            // txtAlimento
            // 
            txtAlimento.Location = new Point(21, 176);
            txtAlimento.Name = "txtAlimento";
            txtAlimento.Size = new Size(172, 27);
            txtAlimento.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(249, 174);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "button1";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lblIndice
            // 
            lblIndice.AutoSize = true;
            lblIndice.Location = new Point(21, 128);
            lblIndice.Name = "lblIndice";
            lblIndice.Size = new Size(50, 20);
            lblIndice.TabIndex = 3;
            lblIndice.Text = "label1";
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(191, 128);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(50, 20);
            lblTexto.TabIndex = 4;
            lblTexto.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 344);
            Controls.Add(lblTexto);
            Controls.Add(lblIndice);
            Controls.Add(btnAdicionar);
            Controls.Add(txtAlimento);
            Controls.Add(cmbAlimentos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAlimentos;
        private TextBox txtAlimento;
        private Button btnAdicionar;
        private Label lblIndice;
        private Label lblTexto;
    }
}