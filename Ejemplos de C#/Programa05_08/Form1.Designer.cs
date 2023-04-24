namespace Programa05_08
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
            lstvAlimentos = new ListView();
            txtbElemento = new TextBox();
            gbGrupos = new GroupBox();
            btnAdicionar = new Button();
            rbtCarnes = new RadioButton();
            rbtFrutas = new RadioButton();
            lblSeleccionado = new Label();
            btnLimpiar = new Button();
            txtImages = new TextBox();
            btnActualizar = new Button();
            btnBorrar = new Button();
            gbGrupos.SuspendLayout();
            SuspendLayout();
            // 
            // lstvAlimentos
            // 
            lstvAlimentos.Location = new Point(12, 12);
            lstvAlimentos.Name = "lstvAlimentos";
            lstvAlimentos.Size = new Size(383, 286);
            lstvAlimentos.TabIndex = 0;
            lstvAlimentos.UseCompatibleStateImageBehavior = false;
            lstvAlimentos.View = View.SmallIcon;
            lstvAlimentos.MouseClick += lstvAlimentos_MouseClick;
            // 
            // txtbElemento
            // 
            txtbElemento.Location = new Point(12, 340);
            txtbElemento.Name = "txtbElemento";
            txtbElemento.Size = new Size(125, 27);
            txtbElemento.TabIndex = 1;
            // 
            // gbGrupos
            // 
            gbGrupos.Controls.Add(btnAdicionar);
            gbGrupos.Controls.Add(rbtCarnes);
            gbGrupos.Controls.Add(rbtFrutas);
            gbGrupos.Location = new Point(145, 318);
            gbGrupos.Name = "gbGrupos";
            gbGrupos.Size = new Size(250, 125);
            gbGrupos.TabIndex = 2;
            gbGrupos.TabStop = false;
            gbGrupos.Text = "Grupos";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(150, 36);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // rbtCarnes
            // 
            rbtCarnes.AutoSize = true;
            rbtCarnes.Location = new Point(26, 79);
            rbtCarnes.Name = "rbtCarnes";
            rbtCarnes.Size = new Size(74, 24);
            rbtCarnes.TabIndex = 4;
            rbtCarnes.TabStop = true;
            rbtCarnes.Text = "Carnes";
            rbtCarnes.UseVisualStyleBackColor = true;
            // 
            // rbtFrutas
            // 
            rbtFrutas.AutoSize = true;
            rbtFrutas.Checked = true;
            rbtFrutas.Location = new Point(26, 38);
            rbtFrutas.Name = "rbtFrutas";
            rbtFrutas.Size = new Size(69, 24);
            rbtFrutas.TabIndex = 3;
            rbtFrutas.TabStop = true;
            rbtFrutas.Text = "Frutas";
            rbtFrutas.UseVisualStyleBackColor = true;
            // 
            // lblSeleccionado
            // 
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.Location = new Point(423, 27);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Size = new Size(50, 20);
            lblSeleccionado.TabIndex = 3;
            lblSeleccionado.Text = "label1";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(423, 82);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtImages
            // 
            txtImages.Location = new Point(12, 373);
            txtImages.Name = "txtImages";
            txtImages.Size = new Size(125, 27);
            txtImages.TabIndex = 5;
            txtImages.Text = "0";
            txtImages.TextAlign = HorizontalAlignment.Right;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(12, 414);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(104, 29);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(423, 117);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 7;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 464);
            Controls.Add(btnBorrar);
            Controls.Add(btnActualizar);
            Controls.Add(txtImages);
            Controls.Add(btnLimpiar);
            Controls.Add(lblSeleccionado);
            Controls.Add(gbGrupos);
            Controls.Add(txtbElemento);
            Controls.Add(lstvAlimentos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbGrupos.ResumeLayout(false);
            gbGrupos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstvAlimentos;
        private TextBox txtbElemento;
        private GroupBox gbGrupos;
        private Button btnAdicionar;
        private RadioButton rbtCarnes;
        private RadioButton rbtFrutas;
        private Label lblSeleccionado;
        private Button btnLimpiar;
        private TextBox txtImages;
        private Button btnActualizar;
        private Button btnBorrar;
    }
}