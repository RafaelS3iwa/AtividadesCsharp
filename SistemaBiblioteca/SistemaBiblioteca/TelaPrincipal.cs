﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroAluno frmCadastroAluno = new FrmCadastroAluno();
            frmCadastroAluno.ShowDialog();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroLivro frmCadastroLivro = new FrmCadastroLivro();
            frmCadastroLivro.ShowDialog();
        }
    }
}