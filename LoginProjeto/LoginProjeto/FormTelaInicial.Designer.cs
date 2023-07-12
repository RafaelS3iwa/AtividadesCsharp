namespace LoginProjeto
{
    partial class FormTelaInicial
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtLoginUsuario = new System.Windows.Forms.Button();
            this.BtLoginEmpresa = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtCadastroUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LoginProjeto.Properties.Resources.logoPMT1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 343);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = global::LoginProjeto.Properties.Resources.MicrosoftTeams_image;
            this.label1.Location = new System.Drawing.Point(68, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bem vindo ao PMT!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Image = global::LoginProjeto.Properties.Resources.MicrosoftTeams_image;
            this.label3.Location = new System.Drawing.Point(89, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Realizar login como:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Image = global::LoginProjeto.Properties.Resources.MicrosoftTeams_image;
            this.label4.Location = new System.Drawing.Point(89, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Se cadastrar como:";
            // 
            // BtLoginUsuario
            // 
            this.BtLoginUsuario.BackColor = System.Drawing.Color.IndianRed;
            this.BtLoginUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLoginUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtLoginUsuario.Location = new System.Drawing.Point(62, 167);
            this.BtLoginUsuario.Name = "BtLoginUsuario";
            this.BtLoginUsuario.Size = new System.Drawing.Size(107, 29);
            this.BtLoginUsuario.TabIndex = 20;
            this.BtLoginUsuario.Text = "Usuário";
            this.BtLoginUsuario.UseVisualStyleBackColor = false;
            this.BtLoginUsuario.Click += new System.EventHandler(this.BtLoginUsuario_Click);
            // 
            // BtLoginEmpresa
            // 
            this.BtLoginEmpresa.BackColor = System.Drawing.Color.IndianRed;
            this.BtLoginEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtLoginEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLoginEmpresa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtLoginEmpresa.Location = new System.Drawing.Point(228, 167);
            this.BtLoginEmpresa.Name = "BtLoginEmpresa";
            this.BtLoginEmpresa.Size = new System.Drawing.Size(107, 29);
            this.BtLoginEmpresa.TabIndex = 21;
            this.BtLoginEmpresa.Text = "Empresa";
            this.BtLoginEmpresa.UseVisualStyleBackColor = false;
            this.BtLoginEmpresa.Click += new System.EventHandler(this.BtLoginEmpresa_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(228, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 29);
            this.button3.TabIndex = 23;
            this.button3.Text = "Empresa";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // BtCadastroUsuario
            // 
            this.BtCadastroUsuario.BackColor = System.Drawing.Color.IndianRed;
            this.BtCadastroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtCadastroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCadastroUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtCadastroUsuario.Location = new System.Drawing.Point(62, 280);
            this.BtCadastroUsuario.Name = "BtCadastroUsuario";
            this.BtCadastroUsuario.Size = new System.Drawing.Size(107, 29);
            this.BtCadastroUsuario.TabIndex = 22;
            this.BtCadastroUsuario.Text = "Usuário";
            this.BtCadastroUsuario.UseVisualStyleBackColor = false;
            this.BtCadastroUsuario.Click += new System.EventHandler(this.BtCadastroUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::LoginProjeto.Properties.Resources.teste1;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.BtCadastroUsuario);
            this.panel1.Controls.Add(this.BtLoginEmpresa);
            this.panel1.Controls.Add(this.BtLoginUsuario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(268, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 343);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginProjeto.Properties.Resources.teste1;
            this.ClientSize = new System.Drawing.Size(659, 343);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormTelaInicial";
            this.Text = "FormTelaInicial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtLoginUsuario;
        private System.Windows.Forms.Button BtLoginEmpresa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtCadastroUsuario;
        private System.Windows.Forms.Panel panel1;
    }
}