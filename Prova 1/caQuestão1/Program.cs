using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestão1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome completo:");
            string nomeCompleto = Console.ReadLine();

            NomeProprio Nome_completo = new NomeProprio(nomeCompleto);
            Console.WriteLine("Nome no formato de paper:");
            Nome_completo.ImprimeNomePaper();
        }
    }
}
