using Prova2Talles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prova2Talles
{   
    class Onibus : Veiculo
    {
        private int NroAssentos;

        public Onibus(int NroAssentos, string placa, int ano) : base(placa, ano)
        {
            this.NroAssentos = NroAssentos;
        }

        public int nroAssentos { get => NroAssentos; set => NroAssentos = value; }

    }
}
