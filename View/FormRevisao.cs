using projeto_acg.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_acg
{
    public partial class FormRevisao : Form
    {
        Conexao conec = new Conexao();
        EnvioDAO envioDAO = new EnvioDAO();

        int idacg = 0;
        int idaluno = 0;

        public FormRevisao()
        {
            InitializeComponent();
        }

        private void FormRevisao_Load(object sender, EventArgs e)
        {
            dgenvio.DataSource = envioDAO.listarEnviosPendentes();
            dgenvio.Columns["Aluno"].Width = 270;
            dgenvio.Columns["Matrícula"].Width = 100;
            dgenvio.Columns["ACG"].Width = 200;
            dgenvio.Columns["Horas"].Width = 70;
            dgenvio.Columns["ID_ACG"].Visible = false;
            dgenvio.Columns["ID_ALUNO"].Visible = false;
        }

        private void dgenvio_CellClick(object sender, DataGridViewCellEventArgs e)
        {//cellclick datagrid
            tbAluno.Text = dgenvio.CurrentRow.Cells[0].Value.ToString();
            tbAcg.Text = dgenvio.CurrentRow.Cells[2].Value.ToString();
            idaluno = int.Parse(dgenvio.CurrentRow.Cells[4].Value.ToString());
            idacg = int.Parse(dgenvio.CurrentRow.Cells[5].Value.ToString());
        }

        private void lbsair_Click(object sender, EventArgs e)
        {//lbsair
            if (MessageBox.Show("Deseja mesmo sair do programa?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void btAceitar_Click(object sender, EventArgs e)
        {//btAceitar
            if (tbAluno.Text == "" || tbAcg.Text == "")
                MessageBox.Show("Nenhum envio foi selecionado!", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                    string sql = @"UPDATE ENVIO SET ACEITO = 1 WHERE ID_ALUNO = @idaluno AND ID_ACG = @idacg";
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@idaluno", idaluno);
                    comando.Parameters.AddWithValue("@idacg", idacg);
                    conexao.Open();
                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                    conexao.Close();

                    MessageBox.Show("Envio aceito com sucesso!", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbAcg.Clear();
                    tbAluno.Clear();
                    dgenvio.DataSource = envioDAO.listarEnviosPendentes();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btRecusar_Click(object sender, EventArgs e)
        {//btRecusar
            if (tbAluno.Text == "" || tbAcg.Text == "")
                MessageBox.Show("Nenhum envio foi selecionado!", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    SqlConnection conexao = new SqlConnection(conec.conexaoBD());
                    string sql = @"DELETE FROM ENVIO WHERE ID_ALUNO = @idaluno AND ID_ACG = @idacg";
                    SqlCommand comando = new SqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@idaluno", idaluno);
                    comando.Parameters.AddWithValue("@idacg", idacg);

                    conexao.Open();
                    comando.CommandText = sql;
                    comando.ExecuteNonQuery();
                    conexao.Close();

                    MessageBox.Show("Envio RECUSADO com sucesso!", "Revisar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbAcg.Clear();
                    tbAluno.Clear();
                    dgenvio.DataSource = envioDAO.listarEnviosPendentes();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro na conexão, tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
