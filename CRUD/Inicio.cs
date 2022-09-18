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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btEvento_Click(object sender, EventArgs e)
        {
            EventoForm evento = new EventoForm();
            evento.Show();

        }

        private void btInstituicao_Click(object sender, EventArgs e)
        {
            InstituicaoForm instituicao = new InstituicaoForm();
            instituicao.Show();

        }
    }
}
