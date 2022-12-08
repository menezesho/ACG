using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_acg.DAO
{
    public class EnvioDAO
    {
        Conexao conec = new Conexao();

        public DataTable listarEnviosPendentes()
        {
            SqlConnection conexao = new SqlConnection(conec.conexaoBD());
            string sql = @"SELECT ALUNO.NOME AS 'Aluno', ALUNO.MATRICULA AS 'Matrícula', ACG.NOME AS 'ACG', ACG.HORAS AS 'Horas', ENVIO.ID_ALUNO, ENVIO.ID_ACG FROM ENVIO
                INNER JOIN ALUNO ON ENVIO.ID_ALUNO = ALUNO.ID
                INNER JOIN ACG ON ENVIO.ID_ACG = ACG.ID
                WHERE ENVIO.ACEITO = 0";
            SqlCommand comando = new SqlCommand(sql, conexao);

            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable tabelaEnvio = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabelaEnvio);
            conexao.Close();

            return tabelaEnvio;
        }

        public DataTable listarEnviosAceitos()
        {
            SqlConnection conexao = new SqlConnection(conec.conexaoBD());
            string sql = @"SELECT ALUNO.NOME AS 'Aluno', ALUNO.MATRICULA AS 'Matrícula', ACG.NOME AS 'ACG', ACG.HORAS AS 'Horas', ENVIO.ID_ALUNO, ENVIO.ID_ACG FROM ENVIO
                INNER JOIN ALUNO ON ENVIO.ID_ALUNO = ALUNO.ID
                INNER JOIN ACG ON ENVIO.ID_ACG = ACG.ID
                WHERE ENVIO.ACEITO = 1";
            SqlCommand comando = new SqlCommand(sql, conexao);

            conexao.Open();
            comando.ExecuteNonQuery();
            DataTable tabelaEnvio = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabelaEnvio);
            conexao.Close();

            return tabelaEnvio;
        }
    }
}
