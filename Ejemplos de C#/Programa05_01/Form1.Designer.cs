namespace Programa05_01
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
            chlbAlimentos = new CheckedListBox();
            txtNuevoALimento = new TextBox();
            btnAdicionar = new Button();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // chlbAlimentos
            // 
            chlbAlimentos.CheckOnClick = true;
            chlbAlimentos.FormattingEnabled = true;
            chlbAlimentos.Items.AddRange(new object[] { "Frijol", "Tomate" });
            chlbAlimentos.Location = new Point(12, 12);
            chlbAlimentos.Name = "chlbAlimentos";
            chlbAlimentos.Size = new Size(408, 202);
            chlbAlimentos.TabIndex = 0;
            chlbAlimentos.SelectedIndexChanged += chlbAlimentos_SelectedIndexChanged;
            // 
            // txtNuevoALimento
            // 
            txtNuevoALimento.Location = new Point(12, 305);
            txtNuevoALimento.Name = "txtNuevoALimento";
            txtNuevoALimento.Size = new Size(181, 27);
            txtNuevoALimento.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(286, 303);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 248);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(50, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 416);
            Controls.Add(lblNombre);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNuevoALimento);
            Controls.Add(chlbAlimentos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox chlbAlimentos;
        private TextBox txtNuevoALimento;
        private Button btnAdicionar;
        private Label lblNombre;
    }
}