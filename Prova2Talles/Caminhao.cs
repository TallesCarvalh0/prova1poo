using Prova2Talles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2Talles
{
    class Caminhao : Veiculo
    {
        private int NroEixos;

        public Caminhao(int NroEixos, string placa, int ano) : base(placa, ano)
        {
            this.NroEixos = NroEixos;
        }


        public int nroEixos { get => NroEixos; set => NroEixos = value; }


    }
}
