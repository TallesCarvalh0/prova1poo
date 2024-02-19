using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestão3
{
    internal class Cliente
    {
        // atributos

        string nome;
        string endereco;
        string telefone;

        //getters e setters
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }

        //construtor

        public Cliente(string _nome, string _endereco, string _telefone) {
        
            nome = _nome;
            endereco = _endereco;
            telefone = _telefone;
        }
    }
}
