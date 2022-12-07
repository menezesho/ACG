using projeto_acg.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_acg
{
    public partial class FormAlterarSenha : Form
    {
        Conexao conec = new Conexao();
        string matriculaAtual = "";

        public FormAlterarSenha(string matricula)
        {
            InitializeComponent();
            matriculaAtual = matricula;

        }

        private void FormAlterarSenha_Load(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {//btLimpar
            if (MessageBox.Show("Os dados não salvos serão perdidos.\nDeseja mesmo limpar todos os campos?", "Limpar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbSenhaAtual.Clear();
                tbNovaSenha.Clear();
                tbConfirmarNovaSenha.Clear();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {//btSalvar
            if (tbNovaSenha.Text == tbConfirmarNovaSenha.Text)
            {
                try
                {

                    Conexao conec = new Conexao();
                    SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                    string sqlSelect1 = @"SELECT * FROM aluno WHERE matricula=@matricula AND senha=@senha";
                    SqlCommand comandoSelect1 = new SqlCommand(sqlSelect1, conexao);

                    comandoSelect1.Parameters.AddWithValue("@matricula", matriculaAtual);
                    comandoSelect1.Parameters.AddWithValue("@senha", tbSenhaAtual.Text);


                    conexao.Open();
                    comandoSelect1.CommandText = sqlSelect1;
                    comandoSelect1.ExecuteNonQuery();
                    SqlDataReader dados1 = comandoSelect1.ExecuteReader();
                    if (dados1.Read())
                    {
                        int id = (int)dados1["id"];
                        conexao.Close();

                        string sqlUpdate = @"UPDATE aluno SET senha=@senha WHERE id=@id";
                        SqlCommand comandoUpdate = new SqlCommand(sqlUpdate, conexao);

                        comandoUpdate.Parameters.AddWithValue("@senha", tbConfirmarNovaSenha.Text);
                        comandoUpdate.Parameters.AddWithValue("@id", id);

                        conexao.Open();
                        comandoUpdate.CommandText = sqlUpdate;
                        comandoUpdate.ExecuteNonQuery();
                        conexao.Close();

                        tbSenhaAtual.Clear();
                        tbNovaSenha.Clear();
                        tbConfirmarNovaSenha.Clear();
                        this.Close();

                        MessageBox.Show("Senha alterada com sucesso!", "Alterar Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("A senha atual informada está incorreta.\nTente novamente!", "Alterar Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbSenhaAtual.Focus();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("As senhas não correspondem.\nTente novamente!", "Alterar Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbNovaSenha.Focus();
            }
        }
        #region Ver Senha

        private void lbVerSenhaAtual_MouseCaptureChanged(object sender, EventArgs e)
        {//btVerSenhaAtual
            if (tbSenhaAtual.UseSystemPasswordChar.Equals(true))
                tbSenhaAtual.UseSystemPasswordChar = false;
            else
                tbSenhaAtual.UseSystemPasswordChar = true;
        }

        private void lbVerNovaSenha_MouseCaptureChanged(object sender, EventArgs e)
        {//btVerNovaSenha
            if (tbNovaSenha.UseSystemPasswordChar.Equals(true))
                tbNovaSenha.UseSystemPasswordChar = false;
            else
                tbNovaSenha.UseSystemPasswordChar = true;
        }

        private void lbVerConfirmarNovaSenha_MouseCaptureChanged(object sender, EventArgs e)
        {//btVerConfirmarNovaSenha
            if (tbConfirmarNovaSenha.UseSystemPasswordChar.Equals(true))
                tbConfirmarNovaSenha.UseSystemPasswordChar = false;
            else
                tbConfirmarNovaSenha.UseSystemPasswordChar = true;
        }

        #endregion
    }
}
