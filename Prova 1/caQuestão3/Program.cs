using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestão3
{
    internal class Program
    {
        static List<Carro> carros = new List<Carro>();
        static List<Cliente> clientes = new List<Cliente>();
        static List<Emprestimo> emprestimos = new List<Emprestimo>();

        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("[1] Cadastrar um carro");
                Console.WriteLine("[2] Cadastrar um cliente");
                Console.WriteLine("[3] Cadastrar um empréstimo");
                Console.WriteLine("[4] Relatório de empréstimos");
                Console.WriteLine("[5] Sair");
                Console.Write("Escolha uma opção: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        CadastrarCarro();
                        break;
                    case "2":
                        CadastrarCliente();
                        break;
                    case "3":
                        CadastrarEmprestimo();
                        break;
                    case "4":
                        RelatorioEmprestimos();
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        static void CadastrarCarro()
        {
            Console.Write("Categoria do carro: ");
            string categoria = Console.ReadLine();
            Console.Write("Marca da empresa: ");
            string marca = Console.ReadLine();
            Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();
            Console.Write("Ano de fabricação: ");
            int ano = int.Parse(Console.ReadLine());

            Carro carro = new Carro(categoria, marca, modelo, ano);
            carros.Add(carro);
        }

        static void CadastrarCliente()
        {
            Console.Write("Nome do cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Endereço do cliente: ");
            string endereco = Console.ReadLine();
            Console.Write("Telefone do cliente: ");
            string telefone = Console.ReadLine();

            Cliente cliente = new Cliente(nome, endereco, telefone);
            clientes.Add(cliente);
        }

        static void CadastrarEmprestimo()
        {
            Console.Write("Nome do cliente: ");
            string nomeCliente = Console.ReadLine();
            Cliente cliente = clientes.Find(c => c.Nome == nomeCliente);
            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado.");
                return;
            }

            Console.WriteLine("Carros disponíveis:");
            for (int i = 0; i < carros.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {carros[i].Marca} {carros[i].Modelo}");
            }
            Console.Write("Escolha o número do carro: ");
            int indiceCarro = int.Parse(Console.ReadLine()) - 1;
            if (indiceCarro < 0 || indiceCarro >= carros.Count)
            {
                Console.WriteLine("Carro inválido.");
                return;
            }

            Console.Write("Preço por dia: ");
            double precoDia = double.Parse(Console.ReadLine());
            Console.Write("Quantidade de dias: ");
            int quantidadeDias = int.Parse(Console.ReadLine());

            Emprestimo emprestimo = new Emprestimo(cliente, carros[indiceCarro], precoDia, quantidadeDias);
            emprestimos.Add(emprestimo);
        }

        static void RelatorioEmprestimos()
        {
            Console.WriteLine("Relatório de empréstimos:");
            foreach (var emprestimo in emprestimos)
            {
                Console.WriteLine($"Cliente: {emprestimo.Cliente.Nome}");
                Console.WriteLine($"Carro: {emprestimo.Carro.Marca} {emprestimo.Carro.Modelo}");
                Console.WriteLine($"Preço por dia: {emprestimo.PrecoPorDia:C}");
                Console.WriteLine($"Quantidade de dias: {emprestimo.QuantidadeDias}");
                Console.WriteLine($"Preço final: {emprestimo.PrecoFinal():C}");
                Console.WriteLine();
            }
        }
    }
}
