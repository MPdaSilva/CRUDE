using CRUD.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class EventoForm : Form
    {
        public EventoForm()
        {
            InitializeComponent();
        }

        private void butIncluirEvento_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento(Convert.ToInt32(texIdEvento.Text), texEventoEvento.Text,texDataInicioEvento.Text,texDataFimEvento.Text,texLocalEvento.Text, Convert.ToDouble(texValorEvento.Text));
            EventoDAO.insiraEvento(evento);

            texEventoEvento.Text = "";
            texDataInicioEvento.Text = "";
            texDataFimEvento.Text = "";
            texLocalEvento.Text = "";
            texValorEvento.Text = "";

        }

        private void butConsultarEvento_Click(object sender, EventArgs e)
        {

            texEventoEvento.Text = "";
            texDataInicioEvento.Text = "";
            texDataFimEvento.Text = "";
            texLocalEvento.Text = "";
            texValorEvento.Text = "";

            Evento evento = EventoDAO.procureEvento(Convert.ToInt32(texIdEvento.Text));
            if (evento != null)
            {
                texEventoEvento.Text = evento.Eventos;
                texDataInicioEvento.Text = evento.DataInicio;
                texDataFimEvento.Text = evento.DataFim;
                texLocalEvento.Text = evento.Local;
                texValorEvento.Text = Convert.ToString(evento.Valor);
         

            }
        }

        private void butDeletarEvento_Click(object sender, EventArgs e)
        {
            EventoDAO.excluaEvento(Convert.ToInt32(texIdEvento.Text));
            texIdEvento.Text = "";
            texEventoEvento.Text = "";
            texDataInicioEvento.Text = "";
            texDataFimEvento.Text = "";
            texLocalEvento.Text = "";
            texValorEvento.Text = "";
        }

        private void butAtualizarEvento_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento(Convert.ToInt32(texIdEvento.Text), texEventoEvento.Text, texDataInicioEvento.Text, texDataFimEvento.Text, texLocalEvento.Text, Convert.ToDouble(texValorEvento.Text));
            EventoDAO.atualizeEvento(evento);
            texEventoEvento.Text = "";
            texDataInicioEvento.Text = "";
            texDataFimEvento.Text = "";
            texLocalEvento.Text = "";
            texValorEvento.Text = "";
            texValorEvento.Text = Convert.ToString(evento.Valor);
        }

        private void butSairEvento_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EventoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
