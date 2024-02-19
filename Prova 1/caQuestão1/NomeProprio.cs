using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestão1
{
    internal class NomeProprio
    {

        //atributos

        string nome_completo;
        string nome_paper;

        //getters e setters
        public string Nome_completo { get => nome_completo; set => nome_completo = value; }
        public string Nome_paper { get => nome_paper; set => nome_paper = value; }

        // construtor
        public NomeProprio(string _nome_completo) { 
        
            nome_completo = _nome_completo;
            nome_paper = build_nome_paper(_nome_completo);
        }

        // Metodo para transformar o nome completo para nome_paper
        private string build_nome_paper(string nome_completo)
        {

            //Armazena o nome em uma string para ser possível fracionar ele e então obter os valores desejados
            string[] nome_fracionado = nome_completo.Split(' ');
            string nome_final = nome_fracionado[nome_fracionado.Length - 1];

            string primeiro_nome = nome_fracionado[0];

            // Constrói o nome em formato paper
            string nome_paper = nome_final + ", " + primeiro_nome;

            // Adiciona os nomes do meio 
            for (int i = 1; i < nome_fracionado.Length - 1; i++)
            {
                string nome_meio = nome_fracionado[i];
                // Adiciona a inicial do nome do meio
                nome_paper += " " + nome_meio[0] + ".";
            }

            return nome_paper;
        }

        // Método para imprimir o nome no formato de papel
        public void ImprimeNomePaper()
        {
            Console.WriteLine(nome_paper);
        }

    }
}
