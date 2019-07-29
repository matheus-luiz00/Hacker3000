using Listar_meus_carros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_meus_carros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> veiculos = new List<Veiculo>();

            var opcaoMenuPrincipal = MenuPrincipal();
            while (opcaoMenuPrincipal != 3)
            {
                if (opcaoMenuPrincipal == 1)
                {
                    Console.Clear();
                    veiculos.Add(new Veiculo()
                    {
                        Modelo = PerguntarParaAdd("modelo"),
                        Ano = int.Parse(PerguntarParaAdd("ano")),
                        Placa = PerguntarParaAdd("placa"),
                        Cavalos = int.Parse(PerguntarParaAdd("cavalos"))
                    });

                    Console.WriteLine("Operação Concluída. Pressione alguma tecla para continuar");
                    Console.ReadKey();
                }
                if (opcaoMenuPrincipal == 2)
                {
                    Console.Clear();
                    foreach (var item in veiculos)
                    {
                        Console.WriteLine($"{item.Modelo} | {item.Ano} | {item.Placa} | {item.Cavalos}");
                    }

                    Console.WriteLine("Operação Concluída. Pressione alguma tecla para continuar");
                    Console.ReadKey();
                }
                opcaoMenuPrincipal = MenuPrincipal();
            }
        }

        static string PerguntarParaAdd(string x)
        {
            Console.WriteLine($"Digite o {x} para adicionar:");
            return Console.ReadLine();
        }
        static void Separador(int n)
        {
            string line = new string('-', n);
            Console.WriteLine(line);
        }

        static void MostrarSejaBemVindo()
        {
            Separador(60);
            Console.WriteLine("SEJA BEM VINDO AO SISTEMA");
            Separador(60);
        }

        static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("\nMenu Inicial");
            Separador(30);
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Adicionar Carro");
            Console.WriteLine("2 - Listar Carros");
            Console.WriteLine("3 - Sair do sistema");
            Separador(30);
            Console.WriteLine("Digite o número desejado:");
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
    }
}
