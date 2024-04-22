using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2Talles
{
    public abstract class Veiculo
    {
        private string placa;
        public int ano;

        public string Placa { get => placa; set => placa = value; }

        protected Veiculo(string _placa, int _ano)
        {
            placa = _placa;
            ano = _ano;
        }

    }
}