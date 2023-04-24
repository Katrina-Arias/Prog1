namespace Programa07_08
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnAdicionarNodo = new System.Windows.Forms.Button();
            this.btnAdicionaElemento = new System.Windows.Forms.Button();
            this.btnLimpiaArbol = new System.Windows.Forms.Button();
            this.btnEliminaNodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(89, 48);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(152, 305);
            this.treeView1.TabIndex = 0;
            // 
            // txtNodo
            // 
            this.txtNodo.Location = new System.Drawing.Point(296, 48);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(100, 23);
            this.txtNodo.TabIndex = 1;
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(296, 90);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(100, 23);
            this.txtElemento.TabIndex = 2;
            // 
            // btnAdicionarNodo
            // 
            this.btnAdicionarNodo.Location = new System.Drawing.Point(449, 47);
            this.btnAdicionarNodo.Name = "btnAdicionarNodo";
            this.btnAdicionarNodo.Size = new System.Drawing.Size(117, 23);
            this.btnAdicionarNodo.TabIndex = 3;
            this.btnAdicionarNodo.Text = "Adiciona nodo";
            this.btnAdicionarNodo.UseVisualStyleBackColor = true;
            this.btnAdicionarNodo.Click += new System.EventHandler(this.btnAdicionarNodo_Click);
            // 
            // btnAdicionaElemento
            // 
            this.btnAdicionaElemento.Location = new System.Drawing.Point(449, 89);
            this.btnAdicionaElemento.Name = "btnAdicionaElemento";
            this.btnAdicionaElemento.Size = new System.Drawing.Size(117, 23);
            this.btnAdicionaElemento.TabIndex = 4;
            this.btnAdicionaElemento.Text = "Adiciona Elemento";
            this.btnAdicionaElemento.UseVisualStyleBackColor = true;
            this.btnAdicionaElemento.Click += new System.EventHandler(this.btnAdicionaElemento_Click);
            // 
            // btnLimpiaArbol
            // 
            this.btnLimpiaArbol.Location = new System.Drawing.Point(449, 128);
            this.btnLimpiaArbol.Name = "btnLimpiaArbol";
            this.btnLimpiaArbol.Size = new System.Drawing.Size(117, 23);
            this.btnLimpiaArbol.TabIndex = 5;
            this.btnLimpiaArbol.Text = "Limpia Arbol";
            this.btnLimpiaArbol.UseVisualStyleBackColor = true;
            this.btnLimpiaArbol.Click += new System.EventHandler(this.btnLimpiaArbol_Click);
            // 
            // btnEliminaNodo
            // 
            this.btnEliminaNodo.Location = new System.Drawing.Point(449, 170);
            this.btnEliminaNodo.Name = "btnEliminaNodo";
            this.btnEliminaNodo.Size = new System.Drawing.Size(117, 23);
            this.btnEliminaNodo.TabIndex = 6;
            this.btnEliminaNodo.Text = "Elimina Nodo";
            this.btnEliminaNodo.UseVisualStyleBackColor = true;
            this.btnEliminaNodo.Click += new System.EventHandler(this.btnEliminaNodo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 427);
            this.Controls.Add(this.btnEliminaNodo);
            this.Controls.Add(this.btnLimpiaArbol);
            this.Controls.Add(this.btnAdicionaElemento);
            this.Controls.Add(this.btnAdicionarNodo);
            this.Controls.Add(this.txtElemento);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView treeView1;
        private TextBox txtNodo;
        private TextBox txtElemento;
        private Button btnAdicionarNodo;
        private Button btnAdicionaElemento;
        private Button btnLimpiaArbol;
        private Button btnEliminaNodo;
    }
}