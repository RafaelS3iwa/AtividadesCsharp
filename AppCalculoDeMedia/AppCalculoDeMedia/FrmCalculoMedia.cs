﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculoDeMedia
{
    public partial class FrmCalculoMedia : Form
    {
        public FrmCalculoMedia()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if(TxtNota1.Text == "" || TxtNota2.Text == "" || TxtNota3.Text == "" || TxtNota4.Text == "")
            {
                //mensagem de alerta
                MessageBox.Show("Por favor, preencha todas as notas", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            double nota1 = Convert.ToDouble(TxtNota1.Text);
            double nota2 = Convert.ToDouble(TxtNota2.Text);
            double nota3 = Convert.ToDouble(TxtNota3.Text);
            double nota4 = Convert.ToDouble(TxtNota4.Text);

            double resultado = (nota1 + nota2 + nota3 + nota4) / 4;

            LblResultadoMedia.Text = resultado.ToString();

            if(resultado >= 7)
            {
                LblSituation.Text = "Aprovado";
                LblSituation.ForeColor = Color.Green;
            }
            else
            {
                LblSituation.Text = "Reprovado";
                LblSituation.ForeColor = Color.Red;
            }
        }
    }
}
