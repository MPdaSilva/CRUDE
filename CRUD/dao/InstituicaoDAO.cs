using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.dao
{
    internal class InstituicaoDAO
    {
        public static bool insiraEvento(Instituicao institiicao)
        {
            bool resultado = false;

            int retorno;
            string comandoSql = "INSERT INTO instituicoes (id_Instituicao, nm_instituicao, ds_cidade, ds_uf) VALUES (@Id, @instituicao, @cidade, @uf)";
            SqlCommand comando = new SqlCommand(comandoSql, Connection.GetConnection());

            SqlParameter idInstituicao = new SqlParameter("@Id", System.Data.SqlDbType.Int, 0);
            SqlParameter instituicaoInstituicao = new SqlParameter("@instituicao", System.Data.SqlDbType.Text, 100);
            SqlParameter cidadeInstituicao = new SqlParameter("@cidade", System.Data.SqlDbType.Text, 10);
            SqlParameter ufInstituicao = new SqlParameter("@uf", System.Data.SqlDbType.Text, 10);


            idInstituicao.Value = institiicao.IdInstituicao;
            instituicaoInstituicao.Value = institiicao.Intituto;
            cidadeInstituicao.Value = institiicao.Cidade;
            ufInstituicao.Value = institiicao.UF;

            comando.Parameters.Add(idInstituicao);
            comando.Parameters.Add(instituicaoInstituicao);
            comando.Parameters.Add(cidadeInstituicao);
            comando.Parameters.Add(ufInstituicao);


            comando.Prepare();
            retorno = comando.ExecuteNonQuery();

            if (retorno > 0)
            {
                resultado = true;
            }
            comando.Dispose();
            return resultado;
        }
        public static Instituicao procureInstituicao(int id)
        {
            Instituicao instituicao = null;

            string comandoSql = "SELECT id_Instituicao, nm_instituicao, ds_cidade, ds_uf FROM instituicoes WHERE id_Instituicao = @id";
            SqlCommand comando = new SqlCommand(comandoSql, Connection.GetConnection());

            SqlParameter idInstituicao = new SqlParameter("@Id", System.Data.SqlDbType.Int, 0);

            idInstituicao.Value = id;

            comando.Parameters.Add(idInstituicao);

            comando.Prepare();
            SqlDataReader leitor = comando.ExecuteReader();

            if (leitor.HasRows)
            {
                leitor.Read();
                instituicao = new Instituicao(
                    Convert.ToInt32(leitor["id_Instituicao"]),
                    leitor["nm_instituicao"].ToString(),
                    leitor["ds_cidade"].ToString(),
                    leitor["ds_uf"].ToString());
            }
            leitor.Close();
            comando.Dispose();

            return instituicao;
        }

        public static List<Instituicao> consulteInstituicao()
        {
            List<Instituicao> instituicaos = new List<Instituicao>();

            string comandoSql = "SELECT id_Instituicao, nm_instituicao, ds_cidade, ds_uf FROM instituicoes";
            SqlCommand comando = new SqlCommand(comandoSql, Connection.GetConnection());

            comando.Prepare();
            SqlDataReader leitor = comando.ExecuteReader();

            Instituicao instituicao;
            while (leitor.Read())
            {

                instituicao = new Instituicao(
                    Convert.ToInt32(leitor["id_Instituicao"]),
                    leitor["nm_instituicao"].ToString(),
                    leitor["ds_cidade"].ToString(),
                    leitor["ds_uf"].ToString());
                instituicaos.Add(instituicao);

            }
            leitor.Close();
            comando.Dispose();

            return instituicaos;
        }

        public static bool atualizeInstituicao(Instituicao institiicao)
        {
            bool resultado = false;

            int retorno;
            string comandoSql = "UPDATE instituicoes SET nm_instituicao=@instituicao, ds_cidade=@cidade, ds_uf=@uf WHERE id_Instituicao=@id";

            SqlCommand comando = new SqlCommand(comandoSql, Connection.GetConnection());

            SqlParameter idInstituicao = new SqlParameter("@Id", System.Data.SqlDbType.Int, 0);
            SqlParameter instituicaoInstituicao = new SqlParameter("@instituicao", System.Data.SqlDbType.Text, 100);
            SqlParameter cidadeInstituicao = new SqlParameter("@cidade", System.Data.SqlDbType.Text, 10);
            SqlParameter ufInstituicao = new SqlParameter("@uf", System.Data.SqlDbType.Text, 10);

            idInstituicao.Value = institiicao.IdInstituicao;
            instituicaoInstituicao.Value = institiicao.Intituto;
            cidadeInstituicao.Value = institiicao.Cidade;
            ufInstituicao.Value = institiicao.UF;

            comando.Parameters.Add(idInstituicao);
            comando.Parameters.Add(instituicaoInstituicao);
            comando.Parameters.Add(cidadeInstituicao);
            comando.Parameters.Add(ufInstituicao);

            comando.Prepare();
            retorno = comando.ExecuteNonQuery();
            if (retorno > 0)
            {
                resultado = true;
            }
            comando.Dispose();

            return resultado;
        }


        public static bool excluaInstituicao(int Id)
        {
            bool resultado = false;

            int retorno;
            string comandoSql = "DELETE FROM instituicoes WHERE id_Instituicao=@id";
            SqlCommand comando = new SqlCommand(comandoSql, Connection.GetConnection());

            SqlParameter id = new SqlParameter("@id", System.Data.SqlDbType.Int, 0);

            id.Value = Id;

            comando.Parameters.Add(id);

            comando.Prepare();
            retorno = comando.ExecuteNonQuery();
            if (retorno > 0)
            {
                resultado = true;
            }
            comando.Dispose();

            return resultado;
        }

    }
}
