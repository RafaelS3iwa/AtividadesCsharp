namespace PMT
{
    partial class FormTelaLoginUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbManterConexao = new System.Windows.Forms.CheckBox();
            this.BtCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CbManterConexao);
            this.panel1.Controls.Add(this.BtCadastrar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BtLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtSenha);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 431);
            this.panel1.TabIndex = 0;
            // 
            // CbManterConexao
            // 
            this.CbManterConexao.AutoSize = true;
            this.CbManterConexao.Location = new System.Drawing.Point(24, 234);
            this.CbManterConexao.Name = "CbManterConexao";
            this.CbManterConexao.Size = new System.Drawing.Size(114, 17);
            this.CbManterConexao.TabIndex = 9;
            this.CbManterConexao.Text = "Manter Conectado";
            this.CbManterConexao.UseVisualStyleBackColor = true;
            // 
            // BtCadastrar
            // 
            this.BtCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.BtCadastrar.ForeColor = System.Drawing.Color.Black;
            this.BtCadastrar.Location = new System.Drawing.Point(151, 382);
            this.BtCadastrar.Name = "BtCadastrar";
            this.BtCadastrar.Size = new System.Drawing.Size(74, 20);
            this.BtCadastrar.TabIndex = 8;
            this.BtCadastrar.Text = "Cadastrar-se";
            this.BtCadastrar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Não possui uma conta?";
            // 
            // BtLogin
            // 
            this.BtLogin.BackgroundImage = global::PMT.Properties.Resources.icons8_arrow_50__1_;
            this.BtLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtLogin.Location = new System.Drawing.Point(98, 280);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(66, 52);
            this.BtLogin.TabIndex = 6;
            this.BtLogin.UseVisualStyleBackColor = true;
            this.BtLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insira a sua Conta de Usuário";
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(24, 196);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(201, 20);
            this.TxtSenha.TabIndex = 1;
            this.TxtSenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(24, 123);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(201, 20);
            this.TxtEmail.TabIndex = 0;
            // 
            // FormTelaLoginUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 427);
            this.Controls.Add(this.panel1);
            this.Name = "FormTelaLoginUsuario";
            this.Text = "TelaLoginUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtLogin;
        private System.Windows.Forms.Button BtCadastrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CbManterConexao;
    }
}