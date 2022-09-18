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
    public partial class InstituicaoForm : Form
    {
        public InstituicaoForm()
        {
            InitializeComponent();
        }

        private void Intituicao_Load(object sender, EventArgs e)
        {

        }

        private void butIncluirInstituicao_Click(object sender, EventArgs e)
        {
            Instituicao instituicao = new Instituicao(Convert.ToInt32(texIdInstituicao.Text), texInstituicaoInstituicao.Text, texCidadeInstituicao.Text, texUfInstituicao.Text);
            InstituicaoDAO.insiraEvento(instituicao);
            texInstituicaoInstituicao.Text = "";
            texCidadeInstituicao.Text = "";
            texUfInstituicao.Text = "";
        }

        private void butConsultarInstituicao_Click(object sender, EventArgs e)
        {
            texInstituicaoInstituicao.Text = "";
            texCidadeInstituicao.Text = "";
            texUfInstituicao.Text = "";

            Instituicao instituicao = InstituicaoDAO.procureInstituicao(Convert.ToInt32(texIdInstituicao.Text));
            if (instituicao != null)
            {

                texInstituicaoInstituicao.Text = instituicao.Intituto;
                texCidadeInstituicao.Text = instituicao.Cidade;
                texUfInstituicao.Text = instituicao.UF;

            }
        }

        private void butAtualizarInstituicao_Click(object sender, EventArgs e)
        {
            
            Instituicao instituicao = new Instituicao(Convert.ToInt32(texIdInstituicao.Text), texInstituicaoInstituicao.Text, texCidadeInstituicao.Text, texUfInstituicao.Text);
            InstituicaoDAO.atualizeInstituicao(instituicao);
        }

        private void butDeletarInstituicao_Click(object sender, EventArgs e)
        {
            InstituicaoDAO.excluaInstituicao(Convert.ToInt32(texIdInstituicao.Text));
            texInstituicaoInstituicao.Text = "";
            texCidadeInstituicao.Text = "";
            texUfInstituicao.Text = "";
        }

        private void butSairInstituicao_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
