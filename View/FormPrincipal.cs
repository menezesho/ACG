﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_acg.View
{
    public partial class FormPrincipal : Form
    {
        string matriculaAtual = "";

        public FormPrincipal()
        {
            InitializeComponent();
        }

        public FormPrincipal(string matricula)
        {
            InitializeComponent();
            matriculaAtual = matricula;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btenviaracg_Click(object sender, EventArgs e)
        {//btenviaracg
            FormEnviarAcg Feacg = new FormEnviarAcg(matriculaAtual);
            Feacg.ShowDialog();
        }

        private void btverificarsituacao_Click(object sender, EventArgs e)
        {//btverificarsituacao
            FormVerificar Fv = new FormVerificar(matriculaAtual);
            Fv.ShowDialog();
        }

        private void btcadastraracg_Click(object sender, EventArgs e)
        {//btcadastraracg
            FormCadAcg Fcacg = new FormCadAcg();
            Fcacg.ShowDialog();
        }

        private void bteditaracgs_Click(object sender, EventArgs e)
        {//bteditaracgs
            FormEditAcg Feacg = new FormEditAcg();
            Feacg.ShowDialog();
        }

        private void bteditaraluno_Click(object sender, EventArgs e)
        {//bteditaraluno
            FormEditAluno Fea = new FormEditAluno();
            Fea.ShowDialog();
        }

        private void btAlterarSenha_Click(object sender, EventArgs e)
        {//btAlterarSenha
            FormAlterarSenha Fas = new FormAlterarSenha(matriculaAtual);
            Fas.ShowDialog();
        }

        private void btRevisar_Click(object sender, EventArgs e)
        {//btRevisar
            FormRevisao Fr = new FormRevisao();
            Fr.ShowDialog();
        }

        private void lbsair_Click(object sender, EventArgs e)
        {//lbsair
            if (MessageBox.Show("Deseja mesmo sair do programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formLogin.Show();
        }
    }
}
