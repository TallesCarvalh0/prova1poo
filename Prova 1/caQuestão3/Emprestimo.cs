using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestão3
{
    internal class Emprestimo
    {
        Cliente cliente;
        Carro carro;
        double precoPorDia;
        int quantidadeDias;

        //getters e setters

        public double PrecoPorDia { get => precoPorDia; set => precoPorDia = value; }
        public int QuantidadeDias { get => quantidadeDias; set => quantidadeDias = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal Carro Carro { get => carro; set => carro = value; }

        //construtor
        public Emprestimo(Cliente _cliente, Carro _carro, double _precoPorDia, int _quantidadeDias)
        {
            cliente = _cliente;
            carro = _carro;
            precoPorDia = _precoPorDia;
            quantidadeDias = _quantidadeDias;
        }

        public double PrecoFinal()
        {
            return precoPorDia * quantidadeDias;
        }
    }
}
