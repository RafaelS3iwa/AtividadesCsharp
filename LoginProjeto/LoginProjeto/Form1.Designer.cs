namespace LoginProjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtEntrar = new System.Windows.Forms.Button();
            this.panelLoginUsuario = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.BtCadastrar = new System.Windows.Forms.Button();
            this.BtVoltar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxLoginEmpresa = new System.Windows.Forms.TextBox();
            this.TextBoxSenhaEmpresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelLoginEmpresa = new System.Windows.Forms.Panel();
            this.panelLoginUsuario.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLoginEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(89, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login de Usuário";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtEmail.Location = new System.Drawing.Point(51, 143);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(309, 26);
            this.TxtEmail.TabIndex = 1;
            this.TxtEmail.Text = "Ex: alguem@email.com";
            this.TxtEmail.Click += new System.EventHandler(this.TxtEmail_Click);

            // 
            // TxtSenha
            // 
            this.TxtSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtSenha.Location = new System.Drawing.Point(50, 202);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(309, 26);
            this.TxtSenha.TabIndex = 2;
            this.TxtSenha.Text = "Sua senha aqui";
            this.TxtSenha.Click += new System.EventHandler(this.TxtSenha_Click);
            this.TxtSenha.TextChanged += new System.EventHandler(this.TxtSenha_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(48, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail ou CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(47, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // BtEntrar
            // 
            this.BtEntrar.BackColor = System.Drawing.Color.IndianRed;
            this.BtEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEntrar.ForeColor = System.Drawing.Color.White;
            this.BtEntrar.Location = new System.Drawing.Point(83, 262);
            this.BtEntrar.Name = "BtEntrar";
            this.BtEntrar.Size = new System.Drawing.Size(240, 34);
            this.BtEntrar.TabIndex = 6;
            this.BtEntrar.Text = "Entrar";
            this.BtEntrar.UseVisualStyleBackColor = false;
            this.BtEntrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // panelLoginUsuario
            // 
            this.panelLoginUsuario.BackColor = System.Drawing.Color.Black;
            this.panelLoginUsuario.BackgroundImage = global::LoginProjeto.Properties.Resources.teste1;
            this.panelLoginUsuario.Controls.Add(this.BtEntrar);
            this.panelLoginUsuario.Controls.Add(this.label4);
            this.panelLoginUsuario.Controls.Add(this.BtCadastrar);
            this.panelLoginUsuario.Controls.Add(this.label3);
            this.panelLoginUsuario.Controls.Add(this.label2);
            this.panelLoginUsuario.Controls.Add(this.TxtSenha);
            this.panelLoginUsuario.Controls.Add(this.TxtEmail);
            this.panelLoginUsuario.Controls.Add(this.label1);
            this.panelLoginUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLoginUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.panelLoginUsuario.Location = new System.Drawing.Point(352, 0);
            this.panelLoginUsuario.Name = "panelLoginUsuario";
            this.panelLoginUsuario.Size = new System.Drawing.Size(390, 438);
            this.panelLoginUsuario.TabIndex = 11;
            this.panelLoginUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = global::LoginProjeto.Properties.Resources.MicrosoftTeams_image;
            this.label4.Location = new System.Drawing.Point(80, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Não possui conta?";
            // 
            // BtCadastrar
            // 
            this.BtCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.BtCadastrar.BackgroundImage = global::LoginProjeto.Properties.Resources.teste1;
            this.BtCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCadastrar.ForeColor = System.Drawing.Color.IndianRed;
            this.BtCadastrar.Location = new System.Drawing.Point(222, 337);
            this.BtCadastrar.Name = "BtCadastrar";
            this.BtCadastrar.Size = new System.Drawing.Size(103, 23);
            this.BtCadastrar.TabIndex = 9;
            this.BtCadastrar.Text = "Cadastre-se";
            this.BtCadastrar.UseVisualStyleBackColor = false;
            // 
            // BtVoltar
            // 
            this.BtVoltar.BackColor = System.Drawing.Color.Transparent;
            this.BtVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtVoltar.ForeColor = System.Drawing.Color.IndianRed;
            this.BtVoltar.Location = new System.Drawing.Point(12, 394);
            this.BtVoltar.Name = "BtVoltar";
            this.BtVoltar.Size = new System.Drawing.Size(62, 32);
            this.BtVoltar.TabIndex = 7;
            this.BtVoltar.Text = "Voltar";
            this.BtVoltar.UseVisualStyleBackColor = false;
            this.BtVoltar.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.BtVoltar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 438);
            this.panel2.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.IndianRed;
            this.button3.Location = new System.Drawing.Point(12, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "Voltar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BtVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LoginProjeto.Properties.Resources.logoPMT1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 438);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(89, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "Login de Empresa";
            // 
            // TextBoxLoginEmpresa
            // 
            this.TextBoxLoginEmpresa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextBoxLoginEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxLoginEmpresa.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBoxLoginEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLoginEmpresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxLoginEmpresa.Location = new System.Drawing.Point(51, 143);
            this.TextBoxLoginEmpresa.Name = "TextBoxLoginEmpresa";
            this.TextBoxLoginEmpresa.Size = new System.Drawing.Size(309, 26);
            this.TextBoxLoginEmpresa.TabIndex = 1;
            this.TextBoxLoginEmpresa.Text = "Ex: empresa@email.com";
            // 
            // TextBoxSenhaEmpresa
            // 
            this.TextBoxSenhaEmpresa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextBoxSenhaEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSenhaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSenhaEmpresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBoxSenhaEmpresa.Location = new System.Drawing.Point(50, 202);
            this.TextBoxSenhaEmpresa.Name = "TextBoxSenhaEmpresa";
            this.TextBoxSenhaEmpresa.Size = new System.Drawing.Size(309, 26);
            this.TextBoxSenhaEmpresa.TabIndex = 2;
            this.TextBoxSenhaEmpresa.Text = "Sua senha aqui";
            this.TextBoxSenhaEmpresa.TextChanged += new System.EventHandler(this.TxtSenha_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(48, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "E-mail ou CNPJ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(47, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Senha";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(83, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Entrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::LoginProjeto.Properties.Resources.teste1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(220, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cadastre-se";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::LoginProjeto.Properties.Resources.MicrosoftTeams_image;
            this.label5.Location = new System.Drawing.Point(78, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Não possui conta?";
            // 
            // panelLoginEmpresa
            // 
            this.panelLoginEmpresa.BackColor = System.Drawing.Color.Black;
            this.panelLoginEmpresa.BackgroundImage = global::LoginProjeto.Properties.Resources.teste1;
            this.panelLoginEmpresa.Controls.Add(this.label5);
            this.panelLoginEmpresa.Controls.Add(this.button1);
            this.panelLoginEmpresa.Controls.Add(this.button2);
            this.panelLoginEmpresa.Controls.Add(this.label6);
            this.panelLoginEmpresa.Controls.Add(this.label7);
            this.panelLoginEmpresa.Controls.Add(this.TextBoxSenhaEmpresa);
            this.panelLoginEmpresa.Controls.Add(this.TextBoxLoginEmpresa);
            this.panelLoginEmpresa.Controls.Add(this.label8);
            this.panelLoginEmpresa.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLoginEmpresa.ForeColor = System.Drawing.SystemColors.Control;
            this.panelLoginEmpresa.Location = new System.Drawing.Point(-38, 0);
            this.panelLoginEmpresa.Name = "panelLoginEmpresa";
            this.panelLoginEmpresa.Size = new System.Drawing.Size(390, 438);
            this.panelLoginEmpresa.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::LoginProjeto.Properties.Resources.teste1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLoginEmpresa);
            this.Controls.Add(this.panelLoginUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";

            this.panelLoginUsuario.ResumeLayout(false);
            this.panelLoginUsuario.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLoginEmpresa.ResumeLayout(false);
            this.panelLoginEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtEntrar;
        private System.Windows.Forms.Panel panelLoginUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLoginEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxSenhaEmpresa;
        private System.Windows.Forms.TextBox TextBoxLoginEmpresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtCadastrar;
        private System.Windows.Forms.Button BtVoltar;
        private System.Windows.Forms.Button button3;
    }
}

