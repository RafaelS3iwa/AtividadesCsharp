namespace PMT
{
    partial class FormTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaInicial));
            this.tituloPmt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtLoginUsuario = new System.Windows.Forms.Button();
            this.BtLoginEmpresa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloPmt
            // 
            this.tituloPmt.AutoSize = true;
            this.tituloPmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloPmt.Location = new System.Drawing.Point(243, 38);
            this.tituloPmt.Name = "tituloPmt";
            this.tituloPmt.Size = new System.Drawing.Size(93, 39);
            this.tituloPmt.TabIndex = 0;
            this.tituloPmt.Text = "PMT";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtLoginEmpresa);
            this.panel1.Controls.Add(this.BtLoginUsuario);
            this.panel1.Location = new System.Drawing.Point(76, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 208);
            this.panel1.TabIndex = 1;
            // 
            // BtLoginUsuario
            // 
            this.BtLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLoginUsuario.Location = new System.Drawing.Point(35, 26);
            this.BtLoginUsuario.Name = "BtLoginUsuario";
            this.BtLoginUsuario.Size = new System.Drawing.Size(361, 54);
            this.BtLoginUsuario.TabIndex = 0;
            this.BtLoginUsuario.Text = "Entrar como Usuário";
            this.BtLoginUsuario.UseVisualStyleBackColor = true;
            this.BtLoginUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtLoginEmpresa
            // 
            this.BtLoginEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLoginEmpresa.Location = new System.Drawing.Point(35, 129);
            this.BtLoginEmpresa.Name = "BtLoginEmpresa";
            this.BtLoginEmpresa.Size = new System.Drawing.Size(361, 54);
            this.BtLoginEmpresa.TabIndex = 1;
            this.BtLoginEmpresa.Text = "Entrar como Empresa";
            this.BtLoginEmpresa.UseVisualStyleBackColor = true;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tituloPmt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaInicial";
            this.Text = "PMT ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloPmt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtLoginEmpresa;
        private System.Windows.Forms.Button BtLoginUsuario;
    }
}

