namespace GeradorValidadorCpf
{
    partial class Form1
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
            this.LblDigitarCpfTexto = new System.Windows.Forms.Label();
            this.TxtdigitarCpf = new System.Windows.Forms.TextBox();
            this.BtnValidarCpf = new System.Windows.Forms.Button();
            this.BtnGerarCPF = new System.Windows.Forms.Button();
            this.TxtGeradorCpf = new System.Windows.Forms.TextBox();
            this.LblGeradorCpfTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblDigitarCpfTexto
            // 
            this.LblDigitarCpfTexto.AutoSize = true;
            this.LblDigitarCpfTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDigitarCpfTexto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblDigitarCpfTexto.Location = new System.Drawing.Point(203, 29);
            this.LblDigitarCpfTexto.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LblDigitarCpfTexto.Name = "LblDigitarCpfTexto";
            this.LblDigitarCpfTexto.Size = new System.Drawing.Size(307, 55);
            this.LblDigitarCpfTexto.TabIndex = 0;
            this.LblDigitarCpfTexto.Text = "Digite o CPF";
            // 
            // TxtdigitarCpf
            // 
            this.TxtdigitarCpf.Location = new System.Drawing.Point(109, 101);
            this.TxtdigitarCpf.Multiline = true;
            this.TxtdigitarCpf.Name = "TxtdigitarCpf";
            this.TxtdigitarCpf.Size = new System.Drawing.Size(520, 44);
            this.TxtdigitarCpf.TabIndex = 1;
            // 
            // BtnValidarCpf
            // 
            this.BtnValidarCpf.BackColor = System.Drawing.Color.Gray;
            this.BtnValidarCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidarCpf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnValidarCpf.Location = new System.Drawing.Point(265, 171);
            this.BtnValidarCpf.Name = "BtnValidarCpf";
            this.BtnValidarCpf.Size = new System.Drawing.Size(190, 59);
            this.BtnValidarCpf.TabIndex = 2;
            this.BtnValidarCpf.Text = "Validar CPF";
            this.BtnValidarCpf.UseVisualStyleBackColor = false;
            // 
            // BtnGerarCPF
            // 
            this.BtnGerarCPF.BackColor = System.Drawing.Color.Gray;
            this.BtnGerarCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerarCPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGerarCPF.Location = new System.Drawing.Point(265, 445);
            this.BtnGerarCPF.Name = "BtnGerarCPF";
            this.BtnGerarCPF.Size = new System.Drawing.Size(190, 59);
            this.BtnGerarCPF.TabIndex = 5;
            this.BtnGerarCPF.Text = "Gerar CPF";
            this.BtnGerarCPF.UseVisualStyleBackColor = false;
            // 
            // TxtGeradorCpf
            // 
            this.TxtGeradorCpf.Location = new System.Drawing.Point(109, 375);
            this.TxtGeradorCpf.Multiline = true;
            this.TxtGeradorCpf.Name = "TxtGeradorCpf";
            this.TxtGeradorCpf.ReadOnly = true;
            this.TxtGeradorCpf.Size = new System.Drawing.Size(520, 44);
            this.TxtGeradorCpf.TabIndex = 4;
            // 
            // LblGeradorCpfTexto
            // 
            this.LblGeradorCpfTexto.AutoSize = true;
            this.LblGeradorCpfTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGeradorCpfTexto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblGeradorCpfTexto.Location = new System.Drawing.Point(187, 300);
            this.LblGeradorCpfTexto.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.LblGeradorCpfTexto.Name = "LblGeradorCpfTexto";
            this.LblGeradorCpfTexto.Size = new System.Drawing.Size(391, 55);
            this.LblGeradorCpfTexto.TabIndex = 3;
            this.LblGeradorCpfTexto.Text = "Gerador de CPF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 577);
            this.Controls.Add(this.BtnGerarCPF);
            this.Controls.Add(this.TxtGeradorCpf);
            this.Controls.Add(this.LblGeradorCpfTexto);
            this.Controls.Add(this.BtnValidarCpf);
            this.Controls.Add(this.TxtdigitarCpf);
            this.Controls.Add(this.LblDigitarCpfTexto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDigitarCpfTexto;
        private System.Windows.Forms.TextBox TxtdigitarCpf;
        private System.Windows.Forms.Button BtnValidarCpf;
        private System.Windows.Forms.Button BtnGerarCPF;
        private System.Windows.Forms.TextBox TxtGeradorCpf;
        private System.Windows.Forms.Label LblGeradorCpfTexto;
    }
}

