using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.dao
{
    internal class Evento
    {
        private int id;
        private string evento;
        private string dataInicio;
        private string dataFim;
        private string local;
        private double valor;

        public int Id 
        { 
            get => id; set => id = value;
        }
        public string Eventos
        {
            get => evento; set => evento = value; 
        }
        public string DataInicio 
        {
            get => dataInicio; set => dataInicio = value;
        }   

        public string DataFim
        {
            get => dataFim; set => dataFim = value;
        }

        public string Local
        {
            get => local; set => local = value;
        }

        public double Valor
        {
            get => valor; set => valor = value;
        }
        public Evento(int id, string evento, string dataInicio, string dataFim, string local, double valor)
        {
            Id = id;
            Eventos = evento;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Local = local;
            Valor = valor;
        }
    }
}
