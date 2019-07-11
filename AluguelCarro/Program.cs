using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AluguelCarro
{
    class Program
    {
        static string[,] carrosList;
        static string carroAlocar;


        static void Main(string[] args)
        {
            bool alugou = false;
            bancoDeDados();
            if(bemVindo() == 1)
            {
                Console.Clear(); 
                header();
                Console.WriteLine("Digite o modelo do carro desejo:");
                carroAlocar = Console.ReadLine().ToString().ToLower();

                while (!alugou)
                {
                    if (pesquisarCarro(carroAlocar))
                    {
                        alugou = alocarCarro(carroAlocar);
                        if (alugou == true)
                        {
                            Console.Clear();
                            header();
                            Console.WriteLine("\n * Carro alocado com sucesso *");
                            separador(30);
                            Console.WriteLine("Lista dos veículos:");
                            listaCarros();
                        }
                    }
                    else
                    {
                        alugou = menuCarroIndisponivel();
                    }

                }
            }
            else if (false)
            {

            } else //Caso o usuário queira sair no menu inicial
            {
                #region Sair
                Console.Clear();
                int cc = 0;
                char backslash = (char) 92;
                string[] carregandoAnim = new string[4] {"|","/","--", "\\" };
                for (int i = 0; i < 15; i++)
                {
                    
                    Console.WriteLine($"Saindo do sistema {carregandoAnim[cc]}");
                    
                    Thread.Sleep(100);
                    cc++;
                    if (cc == 4) cc = 0;
                    Console.Clear();
                }
                
                #endregion
            }
            var input = Console.ReadLine();
        }

        static void bancoDeDados()
        {
            carrosList = new string[5, 5]
            {
                {"Aventador", "Lamborghini", "2017", "Laranja", "Indisponível"},
                {"Corvette Z06", "Chevrolet", "2016", "Amarelo", "Disponível"},
                {"Veyron", "Bulgatti", "2011", "Preto, Vermelho", "Indisponível"},
                {"Mustang GT500", "Shelby", "2019", "Branco, Azul", "Disponível"},
                {"Ferrari 488", "Ferrari", "2016", "Vermelho", "Disponível"}

            };
        }

        public static int bemVindo()
        {
            header();
            Console.WriteLine("\nBem Vindo ao nosso sistema de aluguel de carros de luxo");
            separador(30);
            Console.WriteLine("(1) Alugar veículo\n(2) Sair do Sistema");
            separador(30);
            Console.WriteLine("Escolha uma opção:");
            return int.Parse(Console.ReadLine());
        }

        public static void header()
        {
            separador(30);
            Console.WriteLine(" *   SCIACCA LUXURY CARS   *");
            separador(30);
        }

        public static void separador(int x)
        {
            string line = new string('-', x);
            Console.WriteLine(line);

        }

        public static bool pesquisarCarro(string esc)
        {
            for (int i = 0; i < carrosList.GetLength(0); i++)
            {
                if (carrosList[i,0].ToLower().Contains(esc))
                {
                    Console.WriteLine($"\nModelo: {carrosList[i, 0]} | Fab: {carrosList[i,1]} | Ano: {carrosList[i, 2]} | Cor: {carrosList[i, 3]} | Status: {carrosList[i, 4]}");
                    return carrosList[i, 4] == "Disponível";
                }
                
            }
            return false;
        }
        public static bool alocarCarro(string carroEscolhido)
        {
            Console.WriteLine("\nVocê deseja alocar este carro? (1) Sim (2) Não");
            if(Console.ReadLine() == "1")
            {
                for (int i = 0; i < carrosList.GetLength(0); i++)
                {
                    if (carrosList[i, 0].ToLower().Contains(carroEscolhido.ToLower())) carrosList[i, 4] = "Indisposnível";
                }
                return true;
            }
            return false;
        }

        public static void listaCarros() {
            for (int i = 0; i < carrosList.GetLength(0); i++)
            {
             Console.WriteLine($"Modelo: {carrosList[i, 0]} | Fab: {carrosList[i, 1]} | Ano: {carrosList[i, 2]} | Cor: {carrosList[i, 3]} | Status: {carrosList[i, 4]}");
            }
        }

        public static bool menuCarroIndisponivel()
        {
            separador(30);
            Console.WriteLine("(1) Ver a lista de carros disponíveis\n(2) Pesquisar outro modelo\n(3) Sair");
            Console.WriteLine("Digite a opção desejada:");
            string verification = Console.ReadLine();
            if (verification == "1")
            {
                Console.Clear();
                header();
                Console.WriteLine("Lista completa de carros:");
                listaCarros();
            }
            else if (verification == "2")
            {
                Console.Clear();
                header();
                Console.WriteLine("Digite o modelo do carro desejo:");
                carroAlocar = Console.ReadLine().ToString().ToLower();
            }
            else
            {
                int cc = 0;
                string[] carregandoAnim = new string[4] { "|", "/", "--", "\\" };
                for (int i = 0; i < 10; i++)
                {

                    Console.WriteLine($"Saindo do sistema {carregandoAnim[cc]}");

                    Thread.Sleep(100);
                    cc++;
                    if (cc == 3) cc = 0;
                    Console.Clear();
                }
                return true;
            }
            return false;
        }
    }
    
}
