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
        #region Variaveis_Classe
        //VARIAVEIS STATIC GLOBAIS
        public static string[,] carrosList;
        private static string carroDesejo;
        public static int escolhaMenuInicial = 0;
        #endregion

        //MAIN
        static void Main(string[] args)
        {

            //VARIÁVEIS MAIN
            bool menuBemVindo = false; // variavel de controle loop menu inicial
            

            //CODE
            bancoDeDados(); //carrega a variavel 'carroAlocar' com um array contendo os dados dos carros
            while (escolhaMenuInicial != 4)
            {
                escolhaMenuInicial = bemVindo();//Get o menu que o usuário deseja entrar no Menu Inicial

                //Entra nos menus
                if (escolhaMenuInicial == 1) //Menu Aluguel De Carro
                {
                    menuAluguelCarro();
                }
                else if (escolhaMenuInicial == 2)
                {
                    Console.Clear();
                    header();
                    Console.WriteLine("Lista dos carros");
                    listaCarros();
                }
                else if (escolhaMenuInicial == 3)
                {
                    menuDevolverCarro();
                }
                else //Caso o usuário queira sair no menu inicial
                {
                    #region Sair
                    Console.Clear();
                    escolhaMenuInicial = 4;
                    int cc = 0;
                    char backslash = (char)92;
                    string[] carregandoAnim = new string[4] { "|", "/", "--", "\\" };
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
            Console.WriteLine("(1) Alugar veículo\n(2) Lista de carros\n(3) Devolver veículo\n(4) Sair do Sistema");
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
        public static bool atualizarStatusCarro(string carroEscolhido, string devolverAlocar, bool x) //true para alocar e false para desalocar
        {
            Console.WriteLine($"\nVocê deseja {devolverAlocar} este carro? (1) Sim (2) Não");
            string resposta = Console.ReadLine();
            if (resposta == "1" && x)
            {
                for (int i = 0; i < carrosList.GetLength(0); i++)
                {
                    if (carrosList[i, 0].ToLower().Contains(carroEscolhido.ToLower())) carrosList[i, 4] = "Indisponível";
                }
                return true;
            }
            if (resposta == "1" && !x)
            {
                for (int i = 0; i < carrosList.GetLength(0); i++)
                {
                    if (carrosList[i, 0].ToLower().Contains(carroEscolhido.ToLower())) carrosList[i, 4] = "Disponível";
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
                carroDesejo = Console.ReadLine().ToString().ToLower();
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
                    escolhaMenuInicial = 4;
                }
                return true;
            }
            return false;
        }

        public static void menuAluguelCarro()
        {
            bool alugou = false;
            Console.Clear();
            header();
            Console.WriteLine("Digite o modelo do carro de desejo:"); //Pergunta o carro desejado
            carroDesejo = Console.ReadLine().ToString().ToLower(); //Get carro para pesquisa
            int mod_indisp = 0;
            while (!alugou) //Loop aluguel de carro
            {
                
                if (pesquisarCarro(carroDesejo))
                {
                    alugou = atualizarStatusCarro(carroDesejo, "alocar", true);
                    if (alugou == true)
                    {
                        Console.Clear();
                        header();
                        Console.WriteLine("\n * Carro alocado com sucesso *");
                        separador(30);
                        Console.WriteLine("Lista dos veículos:");
                        listaCarros();
                        escolhaMenuInicial = 4;
                    } else
                    {
                        alugou = true;
                        Console.Clear();
                    }
                }
                else
                {

                    if (mod_indisp == 0)
                    {
                        separador(30);
                        Console.WriteLine("\n!!! Não possuímos este modelo !!!\n");
                        mod_indisp++;
                    }
                        alugou = menuCarroIndisponivel();
                }

            }
            mod_indisp = 0;
        }

        public static void menuDevolverCarro()
        {
            Console.Clear();
            header();
            Console.WriteLine("Lista dos carros:");
            listaCarros();
            separador(30);
            Console.WriteLine("Digite o modelo do carro para devolver"); //Pergunta o carro desejado
            carroDesejo = Console.ReadLine().ToString().ToLower(); //Get carro para pesquisa
            if(atualizarStatusCarro(carroDesejo, "devolver", false))
            {
                Console.Clear();
                header();
                Console.WriteLine("\n * Carro devolvido com sucesso *");
                Console.WriteLine("\nLista dos carros:");
                listaCarros();
                separador(30);
                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            } else
            {
                Console.Clear();
            }
        }
    }
    
}
