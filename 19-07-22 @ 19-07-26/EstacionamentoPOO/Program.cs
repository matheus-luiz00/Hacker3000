using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstacionamentoPOO.Library;

namespace EstacionamentoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento carros = new Estacionamento();
            int escolha = -1;


            while(escolha != 0)
            {
                escolha = menuPrincipal();
                switch (escolha)
                {
                    case 1:
                        {
                            Console.Clear();
                            EntradaSimples(carros);
                            
                            break;
                        };
                    case 2:
                        {
                            Console.Clear();
                            EntradaID(carros);
                            break;
                        };
                    case 3:
                        {
                            Console.Clear();
                            carros.Listar();
                            Console.WriteLine("Pressione ENTER para voltar ao menu principal");
                            Console.ReadLine();
                            break;
                        };
                    case 4:
                        {
                            Console.Clear();
                            carros.ListarSemSaida();
                            Console.WriteLine("Pressione ENTER para voltar ao menu principal");
                            Console.ReadLine();
                            break;
                        };
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("Digite a placa do veículo a ser pesquisado");
                            carros.Listar(Console.ReadLine());
                            Console.WriteLine("Pressione ENTER para voltar ao menu principal");
                            Console.ReadLine();
                            break;
                        };
                    case 6:
                        {
                            Console.Clear();
                            carros.ListarSemSaida();
                            Console.WriteLine("Digite ID do veículo para dar baixa");
                            int.TryParse(Console.ReadLine(), out int id);
                            carros.Saida(id);
                            Console.WriteLine("Operação finalizada");
                            Console.WriteLine("Pressione ENTER para voltar ao menu principal");
                            Console.ReadLine();
                            break;
                        };


                    case 0:
                        {
                            escolha = 0;
                            break;
                        };
                }
            }
        }

        static void EntradaSimples(Estacionamento cr)
        {
            Console.WriteLine("Digite o modelo do veículo:");
            var mod = Console.ReadLine();;
            Console.WriteLine("Digite a placa do veículo:");
            var placa = Console.ReadLine();;
            cr.Entrada(mod, placa);
            Console.WriteLine("Operação realizada com sucesso\n");
            Console.WriteLine("Pressione ENTER para voltar ao menu principal");
            Console.ReadLine();
        }

        static void EntradaID(Estacionamento cr)
        {
            Console.WriteLine("Digite o ID do veículo:");
            int.TryParse(Console.ReadLine(), out int id);
            cr.Entrada(id);
            Console.WriteLine("Operação realizada com sucesso\n");
            Console.WriteLine("Pressione ENTER para voltar ao menu principal");
            Console.ReadLine();
        }
        static int menuPrincipal()
        {
            Console.Clear();

            mostrarSejaBemVindo();

            Console.WriteLine("\nMenu Inicial");
            separador(30);
            Console.WriteLine("O que você deseja realizar?\n");
            Console.WriteLine("1 - Entrada em um veículo");
            Console.WriteLine("2 - Reentrada em um veículo");
            Console.WriteLine("3 - Listar TODOS os veículos");
            Console.WriteLine("4 - Listar veículos SEM SAIDA");
            Console.WriteLine("5 - Pesquisar veículo por placa");
            Console.WriteLine("6 - Dar saída em um veículo");
            Console.WriteLine("0 - Sair do sistema");
            separador(30);
            Console.WriteLine("Digite o número desejado:");
            int.TryParse(Console.ReadLine(), out int opcao);

            return opcao;
        }

        static void mostrarSejaBemVindo()
        {
            separador(60);
            Console.WriteLine("            SISTEMA ESTACIONAMENTO");
            separador(60);
        }

        static void separador(int n)
        {
            string line = new string('-', n);
            Console.WriteLine(line);
        }
    }
}
