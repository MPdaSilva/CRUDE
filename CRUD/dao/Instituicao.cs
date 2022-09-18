using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.dao
{
    internal class Instituicao
    {
        private int idInstituicao;
        private string intituto;
        private string cidade;
        private string uf;

        public int IdInstituicao
        {
            get => idInstituicao; set => idInstituicao = value;
        }
        public string Intituto
        {
            get => intituto; set => intituto = value;
        }
        public string Cidade
        {
            get => cidade; set => cidade = value;
        }
        
        public string UF
        {
            get => uf; set => uf = value;
        }
       
        public Instituicao(int idInstituicao, string intituto, string cidade, string uf)
        {
            IdInstituicao = idInstituicao;
            Intituto = intituto;
            Cidade = cidade;
            UF = uf;
          
            
        }
    }
}
