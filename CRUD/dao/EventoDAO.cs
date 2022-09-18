using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.dao
{
    internal class EventoDAO
    {
        public static bool insiraEvento(Evento evento)
        {
            bool resultado = false;

            int retorno;
            string comandoSql = "INSERT INTO eventos (Id, evento, data_inicio, data_fim, local, valor) VALUES (@Id, @evento, @dataInicio, @dataFim, @local, @valor) ";
            SqlCommand comando = new SqlCommand(comandoSql, Connection.GetConnection());

            SqlParameter id = new SqlParameter("@Id", System.Data.SqlDbType.Int, 0);
            SqlParameter eventoEvento = new SqlParameter("@evento", System.Data.SqlDbType.Text, 100);
            SqlParameter dataInicioEvento = new SqlParameter("@dataInicio", System.Data.SqlDbType.Text, 10);
            SqlParameter dataFimEvento = new SqlParameter("@dataFim", System.Data.SqlDbType.Text, 10);
            SqlParameter localEvento = new SqlParameter("@local", System.Data.SqlDbType.Text, 100);
            SqlParameter valorEvento = new SqlParameter("@valor", System.Data.SqlDbType.Float, 0);
        
            id.Value = evento.Id;
            eventoEvento.Value = evento.Eventos;
            dataInicioEvento.Value = evento.DataInicio;
            dataFimEvento.Value = evento.DataFim;
            localEvento.Value = evento.Local;
            valorEvento.Value = evento.Valor;

            comando.Parameters.Add(id);
            comando.Parameters.Add(eventoEvento);
            comando.Parameters.Add(dataInicioEvento);
            comando.Parameters.Add(dataFimEvento);
            comando.Parameters.Add(localEvento);
            comando.Parameters.Add(valorEvento);

            comando.Prepare();
            retorno = comando.ExecuteNonQuery();

            if (retorno > 0)
            {
                resultado = true;
            }
            comando.Dispose();
            return resultado;
        }
        public static Evento procureEvento(int id)
        {
            Evento evento = null;

            string comandoSql = "SELECT Id, evento, data_inicio, data_fim, local, valor FROM eventos WHERE Id = @id";
            SqlCommand comando = new SqlCommand(comandoSql, Connection.GetConnection());

            SqlParameter Id = new SqlParameter("@id", System.Data.SqlDbType.Int, 0);

            Id.Value = id;

            comando.Parameters.Add(Id);

            comando.Prepare();
            SqlDataReader leitor = comando.ExecuteReader();

            if (leitor.HasRows)
            {
                leitor.Read();
                evento = new Evento(
                    Convert.ToInt32(leitor["Id"]),
                    leitor["evento"].ToString(), 
                    leitor["data_inicio"].ToString(),
                    leitor["data_fim"].ToString(),
                    leitor["local"].ToString(),
                    Convert.ToInt32(leitor["valor"]));
            }
            leitor.Close();
            comando.Dispose();

            return evento;
        }

        public static List<Evento> consulteEventos()

        {
            List<Evento> eventos = new List<Evento>();

            string comandoSql = "SELECT Id, evento, data_inicio, data_fim, local, valor FROM eventos";
            SqlCommand comando = new SqlCommand(comandoSql, Connection.GetConnection());

            comando.Prepare();
            SqlDataReader leitor = comando.ExecuteReader();

            Evento evento;
            while (leitor.Read())
            {

                evento = new Evento(
                    Convert.ToInt32(leitor["Id"]),
                    leitor["evento"].ToString(),
                    leitor["data_inicio"].ToString(),
                    leitor["data_fim"].ToString(),
                    leitor["local"].ToString(),
                    Convert.ToInt32(leitor["valor"]));
                eventos.Add(evento);

            }
            leitor.Close();
            comando.Dispose();

            return eventos;
        }

        public static bool atualizeEvento(Evento evento)
        {
            bool resultado = false;

            int retorno;
            string comandoSql = "UPDATE eventos SET evento=@evento, data_inicio=@dataInicio, data_fim=@dataFim, local=@local, valor=@valor WHERE Id=@id";

            SqlCommand comando = new SqlCommand(comandoSql, Connection.GetConnection());

            SqlParameter id = new SqlParameter("@Id", System.Data.SqlDbType.Int, 0);
            SqlParameter eventoEvento = new SqlParameter("@evento", System.Data.SqlDbType.Text, 100);
            SqlParameter dataInicioEvento = new SqlParameter("@dataInicio", System.Data.SqlDbType.Text, 10);
            SqlParameter dataFimEvento = new SqlParameter("@dataFim", System.Data.SqlDbType.Text, 10);
            SqlParameter localEvento = new SqlParameter("@local", System.Data.SqlDbType.Text, 100);
            SqlParameter valorEvento = new SqlParameter("@valor", System.Data.SqlDbType.Int, 15);

            id.Value = evento.Id;
            eventoEvento.Value = evento.Eventos;
            dataInicioEvento.Value = evento.DataInicio;
            dataFimEvento.Value = evento.DataFim;
            localEvento.Value = evento.Local;
            valorEvento.Value = evento.Valor;

            comando.Parameters.Add(id);
            comando.Parameters.Add(eventoEvento);
            comando.Parameters.Add(dataInicioEvento);
            comando.Parameters.Add(dataFimEvento);
            comando.Parameters.Add(localEvento);
            comando.Parameters.Add(valorEvento);


            comando.Prepare();
            retorno = comando.ExecuteNonQuery();
            if (retorno > 0)
            {
                resultado = true;
            }
            comando.Dispose();

            return resultado;
        }


        public static bool excluaEvento(int Id)
        {
            bool resultado = false;

            int retorno;
            string comandoSql = "DELETE FROM eventos WHERE Id=@id";
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
