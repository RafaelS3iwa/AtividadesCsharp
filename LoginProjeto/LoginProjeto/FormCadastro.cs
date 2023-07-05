﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProjeto
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            PanUsuario1.Visible = true;
            PanUsuario2.Visible = false;
            PanUsuario3.Visible = false;
        }

        private void BtContinuar_Click(object sender, EventArgs e)
        {
            if(PanUsuario1.Visible == true)
            {
                PanUsuario1.Visible = false;
                PanUsuario2.Visible = true;
                PanUsuario3.Visible = false;
            }
            else if(PanUsuario2.Visible == true)
            {
                PanUsuario1.Visible = false;
                PanUsuario2.Visible = false;
                PanUsuario3.Visible = true;
            }
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            if (PanUsuario1.Visible == true)
            {
                PanUsuario1.Visible = false;
                PanUsuario2.Visible = true;
                PanUsuario3.Visible = false;
            }
            else if (PanUsuario2.Visible == true)
            {
                PanUsuario1.Visible = true;
                PanUsuario2.Visible = false;
                PanUsuario3.Visible = false;
            }
            else if (PanUsuario3.Visible == true)
            {
                PanUsuario1.Visible = false;
                PanUsuario2.Visible = true;
                PanUsuario3.Visible = false;
            }
        }

        private void BtConcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
