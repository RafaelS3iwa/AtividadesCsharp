namespace ValidarCpfOuCnpj
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
            this.RdCpf = new System.Windows.Forms.RadioButton();
            this.RdCnpj = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LblTexto = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RdCpf
            // 
            this.RdCpf.AutoSize = true;
            this.RdCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdCpf.Location = new System.Drawing.Point(107, 124);
            this.RdCpf.Name = "RdCpf";
            this.RdCpf.Size = new System.Drawing.Size(61, 24);
            this.RdCpf.TabIndex = 0;
            this.RdCpf.TabStop = true;
            this.RdCpf.Text = "CPF";
            this.RdCpf.UseVisualStyleBackColor = true;
            this.RdCpf.CheckedChanged += new System.EventHandler(this.RdCpf_CheckedChanged);
            // 
            // RdCnpj
            // 
            this.RdCnpj.AutoSize = true;
            this.RdCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdCnpj.Location = new System.Drawing.Point(346, 124);
            this.RdCnpj.Name = "RdCnpj";
            this.RdCnpj.Size = new System.Drawing.Size(71, 24);
            this.RdCnpj.TabIndex = 1;
            this.RdCnpj.TabStop = true;
            this.RdCnpj.Text = "CNPJ";
            this.RdCnpj.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LblTexto
            // 
            this.LblTexto.AutoSize = true;
            this.LblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTexto.Location = new System.Drawing.Point(101, 30);
            this.LblTexto.Name = "LblTexto";
            this.LblTexto.Size = new System.Drawing.Size(311, 31);
            this.LblTexto.TabIndex = 5;
            this.LblTexto.Text = "Validador CPF e CNPJ";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(123, 179);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(267, 29);
            this.TxtNumero.TabIndex = 6;
            this.TxtNumero.TextChanged += new System.EventHandler(this.TxtNumero_TextChanged);
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 413);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.LblTexto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RdCnpj);
            this.Controls.Add(this.RdCpf);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Validação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdCpf;
        private System.Windows.Forms.RadioButton RdCnpj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LblTexto;
        private System.Windows.Forms.TextBox TxtNumero;
    }
}

