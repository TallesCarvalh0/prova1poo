using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestão3
{
    internal class Carro
    {
        //atributos
        string categoria;
        string marca;
        string modelo;
        int anoFabricacao;
        
        //getters e setters
        public string Categoria { get => categoria; set => categoria = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int AnoFabricacao { get => anoFabricacao; set => anoFabricacao = value; }

        //construtor
        public Carro(string _categoria, string _marca, string _modelo, int _anoFabricacao)
        {
            categoria = _categoria;
            marca = _marca;
            modelo = _modelo;
            anoFabricacao= _anoFabricacao;
        }

    }
}
