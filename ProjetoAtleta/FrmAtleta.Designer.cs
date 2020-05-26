namespace ProjetoAtleta
{
    partial class FrmAtleta
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_imc = new System.Windows.Forms.Button();
            this.lbl_imc = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_imc
            // 
            this.btn_imc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imc.Location = new System.Drawing.Point(62, 267);
            this.btn_imc.Name = "btn_imc";
            this.btn_imc.Size = new System.Drawing.Size(204, 41);
            this.btn_imc.TabIndex = 42;
            this.btn_imc.Text = "Calcular IMC";
            this.btn_imc.UseVisualStyleBackColor = true;
            this.btn_imc.Click += new System.EventHandler(this.btn_imc_Click);
            // 
            // lbl_imc
            // 
            this.lbl_imc.AutoSize = true;
            this.lbl_imc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_imc.Location = new System.Drawing.Point(137, 334);
            this.lbl_imc.Name = "lbl_imc";
            this.lbl_imc.Size = new System.Drawing.Size(55, 25);
            this.lbl_imc.TabIndex = 41;
            this.lbl_imc.Text = "IMC:";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_peso.Location = new System.Drawing.Point(24, 175);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(52, 20);
            this.lbl_peso.TabIndex = 40;
            this.lbl_peso.Text = "Peso:";
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_altura.Location = new System.Drawing.Point(24, 125);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(58, 20);
            this.lbl_altura.TabIndex = 39;
            this.lbl_altura.Text = "Altura:";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_idade.Location = new System.Drawing.Point(24, 75);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(54, 20);
            this.lbl_idade.TabIndex = 38;
            this.lbl_idade.Text = "Idade:";
            // 
            // txt_result
            // 
            this.txt_result.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_result.Enabled = false;
            this.txt_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_result.Location = new System.Drawing.Point(107, 373);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(115, 56);
            this.txt_result.TabIndex = 37;
            this.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_enviar
            // 
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Location = new System.Drawing.Point(62, 220);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(204, 41);
            this.btn_enviar.TabIndex = 36;
            this.btn_enviar.Text = "Enviar Dados";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(100, 22);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(206, 22);
            this.txt_nome.TabIndex = 35;
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(100, 72);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(206, 22);
            this.txt_idade.TabIndex = 34;
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(100, 122);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(206, 22);
            this.txt_altura.TabIndex = 33;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(100, 172);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(206, 22);
            this.txt_peso.TabIndex = 32;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_nome.Location = new System.Drawing.Point(24, 25);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(58, 20);
            this.lbl_nome.TabIndex = 31;
            this.lbl_nome.Text = "Nome:";
            // 
            // FrmAtleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.btn_imc);
            this.Controls.Add(this.lbl_imc);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.lbl_nome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAtleta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atleta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_imc;
        private System.Windows.Forms.Label lbl_imc;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label lbl_nome;
    }
}

