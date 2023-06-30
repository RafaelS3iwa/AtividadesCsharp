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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MsValidar = new System.Windows.Forms.ToolStripMenuItem();
            this.MsGerador = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblTexto = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RdCnpj = new System.Windows.Forms.RadioButton();
            this.RdCpf = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtNumeroGerado = new System.Windows.Forms.TextBox();
            this.LblGerador = new System.Windows.Forms.Label();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtGerar = new System.Windows.Forms.Button();
            this.RdGerarCnpj = new System.Windows.Forms.RadioButton();
            this.RdGerarCpf = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsValidar,
            this.MsGerador});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MsValidar
            // 
            this.MsValidar.Name = "MsValidar";
            this.MsValidar.Size = new System.Drawing.Size(68, 20);
            this.MsValidar.Text = "Validador";
            this.MsValidar.Click += new System.EventHandler(this.MsValidar_Click);
            // 
            // MsGerador
            // 
            this.MsGerador.Name = "MsGerador";
            this.MsGerador.Size = new System.Drawing.Size(61, 20);
            this.MsGerador.Text = "Gerador";
            this.MsGerador.Click += new System.EventHandler(this.MsGerar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtNumero);
            this.panel1.Controls.Add(this.LblTexto);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.RdCnpj);
            this.panel1.Controls.Add(this.RdCpf);
            this.panel1.Location = new System.Drawing.Point(22, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 371);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TxtNumero
            // 
            this.TxtNumero.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(103, 145);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(267, 30);
            this.TxtNumero.TabIndex = 9;
            this.TxtNumero.TextChanged += new System.EventHandler(this.TxtNumero_TextChanged);
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            // 
            // LblTexto
            // 
            this.LblTexto.AutoSize = true;
            this.LblTexto.Font = new System.Drawing.Font("News706 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTexto.Location = new System.Drawing.Point(55, 18);
            this.LblTexto.Name = "LblTexto";
            this.LblTexto.Size = new System.Drawing.Size(371, 39);
            this.LblTexto.TabIndex = 6;
            this.LblTexto.Text = "Validador CPF e CNPJ";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(150, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(148, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RdCnpj
            // 
            this.RdCnpj.AutoSize = true;
            this.RdCnpj.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdCnpj.Location = new System.Drawing.Point(326, 102);
            this.RdCnpj.Name = "RdCnpj";
            this.RdCnpj.Size = new System.Drawing.Size(73, 23);
            this.RdCnpj.TabIndex = 8;
            this.RdCnpj.Text = "CNPJ";
            this.RdCnpj.UseVisualStyleBackColor = true;
            // 
            // RdCpf
            // 
            this.RdCpf.AutoSize = true;
            this.RdCpf.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdCpf.Location = new System.Drawing.Point(84, 102);
            this.RdCpf.Name = "RdCpf";
            this.RdCpf.Size = new System.Drawing.Size(62, 23);
            this.RdCpf.TabIndex = 7;
            this.RdCpf.Text = "CPF";
            this.RdCpf.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtNumeroGerado);
            this.panel2.Controls.Add(this.LblGerador);
            this.panel2.Controls.Add(this.BtCancelar);
            this.panel2.Controls.Add(this.BtGerar);
            this.panel2.Controls.Add(this.RdGerarCnpj);
            this.panel2.Controls.Add(this.RdGerarCpf);
            this.panel2.Location = new System.Drawing.Point(22, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 374);
            this.panel2.TabIndex = 12;
            // 
            // TxtNumeroGerado
            // 
            this.TxtNumeroGerado.Font = new System.Drawing.Font("News706 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroGerado.Location = new System.Drawing.Point(103, 145);
            this.TxtNumeroGerado.Name = "TxtNumeroGerado";
            this.TxtNumeroGerado.Size = new System.Drawing.Size(267, 30);
            this.TxtNumeroGerado.TabIndex = 9;
            // 
            // LblGerador
            // 
            this.LblGerador.AutoSize = true;
            this.LblGerador.Font = new System.Drawing.Font("News706 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGerador.Location = new System.Drawing.Point(55, 18);
            this.LblGerador.Name = "LblGerador";
            this.LblGerador.Size = new System.Drawing.Size(350, 39);
            this.LblGerador.TabIndex = 6;
            this.LblGerador.Text = "Gerador CPF e CNPJ";
            // 
            // BtCancelar
            // 
            this.BtCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCancelar.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancelar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtCancelar.Location = new System.Drawing.Point(150, 306);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(167, 36);
            this.BtCancelar.TabIndex = 11;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtGerar
            // 
            this.BtGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtGerar.Font = new System.Drawing.Font("News706 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtGerar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtGerar.Location = new System.Drawing.Point(148, 222);
            this.BtGerar.Name = "BtGerar";
            this.BtGerar.Size = new System.Drawing.Size(169, 39);
            this.BtGerar.TabIndex = 10;
            this.BtGerar.Text = "Ok";
            this.BtGerar.UseVisualStyleBackColor = true;
            this.BtGerar.Click += new System.EventHandler(this.BtGerar_Click);
            // 
            // RdGerarCnpj
            // 
            this.RdGerarCnpj.AutoSize = true;
            this.RdGerarCnpj.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdGerarCnpj.Location = new System.Drawing.Point(326, 102);
            this.RdGerarCnpj.Name = "RdGerarCnpj";
            this.RdGerarCnpj.Size = new System.Drawing.Size(73, 23);
            this.RdGerarCnpj.TabIndex = 8;
            this.RdGerarCnpj.Text = "CNPJ";
            this.RdGerarCnpj.UseVisualStyleBackColor = true;
            // 
            // RdGerarCpf
            // 
            this.RdGerarCpf.AutoSize = true;
            this.RdGerarCpf.Font = new System.Drawing.Font("News706 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdGerarCpf.Location = new System.Drawing.Point(84, 102);
            this.RdGerarCpf.Name = "RdGerarCpf";
            this.RdGerarCpf.Size = new System.Drawing.Size(62, 23);
            this.RdGerarCpf.TabIndex = 7;
            this.RdGerarCpf.Text = "CPF";
            this.RdGerarCpf.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 413);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Validação";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MsValidar;
        private System.Windows.Forms.ToolStripMenuItem MsGerador;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblTexto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RdCnpj;
        private System.Windows.Forms.RadioButton RdCpf;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtNumeroGerado;
        private System.Windows.Forms.Label LblGerador;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtGerar;
        private System.Windows.Forms.RadioButton RdGerarCnpj;
        private System.Windows.Forms.RadioButton RdGerarCpf;
    }
}

