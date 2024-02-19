using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestão2
{
    internal class NumComplexo
    {

        //atributos 

        double Re;
        double Im;

        //construtor

        public NumComplexo(double _Re, double _Im)
        {
            Re = _Re;
            Im = _Im;
        }

        //Metodo de soma
        public NumComplexo soma(NumComplexo NumComplexo2)
        {
            double soma_real = Re + NumComplexo2.Re;
            double soma_imaginaria = Im + NumComplexo2.Im;

     
            return new NumComplexo(soma_real, soma_imaginaria);
        }

        //Metodo de multiplicacao
        public NumComplexo vezes(NumComplexo NumComplexo2)
        {
            double produto_real = (Re * NumComplexo2.Re) - (Im * NumComplexo2.Im);
            double produto_imaginario = (Re * NumComplexo2.Im) + (Im * NumComplexo2.Re);


            return new NumComplexo(produto_real, produto_imaginario);
        }

        // Metodo do modulo

        public double Modulo()
        {
            return Math.Sqrt(Re * Re + Im * Im);
        }

        public double Argumento() { 
        
            return Math.Atan2(Im,Re);
        }

        public void ImprimeFormaPolar()
        {
            double modulo = Modulo();
            double argumento = Argumento();
            Console.WriteLine($"{modulo} * (cos({argumento}) + i * sin({argumento}))");
        }

        //getters e setters
        public double Re1 { get => Re; set => Re = value; }
        public double Im1 { get => Im; set => Im = value; }
    }
}
