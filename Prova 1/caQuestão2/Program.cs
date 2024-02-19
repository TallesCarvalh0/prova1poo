using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestão2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            NumComplexo z1 = new NumComplexo(1, 1);
            NumComplexo z2 = new NumComplexo(3, -1);

            // soma
            NumComplexo soma = z1.soma(z2);
            Console.WriteLine("Forma polar da soma:");
            soma.ImprimeFormaPolar();

            // produto
            NumComplexo produto = z1.vezes(z2);
            Console.WriteLine("Forma polar do produto:");
            produto.ImprimeFormaPolar();

            Console.ReadLine();
        }
    }
}
