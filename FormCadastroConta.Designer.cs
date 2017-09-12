namespace projetoBanco
{
    partial class FormCadastroConta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.buttonCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titular";
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(141, 31);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 2;
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(141, 66);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 3;
            // 
            // buttonCadastro
            // 
            this.buttonCadastro.Location = new System.Drawing.Point(166, 111);
            this.buttonCadastro.Name = "buttonCadastro";
            this.buttonCadastro.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastro.TabIndex = 4;
            this.buttonCadastro.Text = "Cadastrar";
            this.buttonCadastro.UseVisualStyleBackColor = true;
            this.buttonCadastro.Click += new System.EventHandler(this.buttonCadastro_Click);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 165);
            this.Controls.Add(this.buttonCadastro);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroConta";
            this.Text = "FormCadastroConta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Button buttonCadastro;
    }
}