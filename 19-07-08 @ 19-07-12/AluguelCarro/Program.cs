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
        public static int escolhaMenuInicial = 0;
        #endregion

        //MAIN
        static void Main(string[] args)
        {

            //VARIÁVEIS MAIN
            bool menuBemVindo = false; // variavel de controle loop menu inicial
            bool xxx = true; //Variavel que mostra o header do bem vindo ou não

            //CODE
            bancoDeDados(); //carrega a variavel 'carroAlocar' com um array contendo os dados dos carros
            while (escolhaMenuInicial != 4)
            {

                escolhaMenuInicial = bemVindo(xxx);//Get o menu que o usuário deseja entrar no Menu Inicial

                //Entra nos menus
                if (escolhaMenuInicial == 1) //Menu Aluguel De Carro
                {
                    menuAluguelCarro();
                    xxx = true;
                }
                else if (escolhaMenuInicial == 2)
                {
                    Console.Clear();
                    header();
                    Console.WriteLine("Lista dos carros");
                    listaCarros();
                    xxx = false;
                }
                else if (escolhaMenuInicial == 3)
                {
                    menuDevolverCarro();
                    xxx = true;
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

        public static int bemVindo(bool a)
        {
            if(a)header();
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

        /// <summary>
        /// Retorna se o carro pesquisado existe, e caso existir se está disponível ou não
        /// </summary>
        /// <param name="escolha">Carro a ser pesquisado</param>
        /// <returns>true = Disponível / false = Indisponível / null = Inexistente</returns>
        public static bool? pesquisarExistenciaDoCarro(string escolha)
        {
            for (int i = 0; i < carrosList.GetLength(0); i++)
            {
                bool testeExistencia = carrosList[i, 0].ToLower().Replace(" ", "").Contains(escolha);
                if (testeExistencia == true)
                {
                    Console.WriteLine($"\nModelo: {carrosList[i, 0]} | Fab: {carrosList[i,1]} | Ano: {carrosList[i, 2]} | Cor: {carrosList[i, 3]} | Status: {carrosList[i, 4]}");
                    return (carrosList[i, 4] == "Disponível" ); //teste lógico
                }
                
            }
            return null;

        }
        public static bool atualizarStatusCarro(string carroEscolhido, string devolverOuAlocar, bool x) //true para alocar e false para desalocar
        {
            Console.WriteLine($"\nVocê deseja {devolverOuAlocar} este carro? (1) Sim (2) Não");
            string resposta = Console.ReadLine();
            if (resposta == "1" && x)
            {
                for (int i = 0; i < carrosList.GetLength(0); i++)
                {
                    if (carrosList[i, 0].ToLower().Replace(" ","").Contains(carroEscolhido.ToLower().Replace(" ",""))) carrosList[i, 4] = "Indisponível";
                }
                return true;
            }
            if (resposta == "1" && !x)
            {
                for (int i = 0; i < carrosList.GetLength(0); i++)
                {
                    if (carrosList[i, 0].ToLower().Replace(" ","").Contains(carroEscolhido.ToLower().Replace(" ",""))) carrosList[i, 4] = "Disponível";
                }
                return true;
            }
            return false;
        }

        public static void listaCarros() {
            for (int i = 0; i < carrosList.GetLength(0); i++)
            {
             Console.WriteLine($"Modelo: {carrosList[i, 0]}\t | Fab: {carrosList[i, 1]}\t | Ano: {carrosList[i, 2]}\t | Cor: {carrosList[i, 3]}\t | Status: {carrosList[i, 4]}");
            }
        }

        public static bool menuCarroIndisponivel(ref string carroDesejo)
        {
            separador(30);
            Console.WriteLine("(1) Ver a lista de carros\n(2) Digitar outro modelo\n(3) Voltar\n(4) Sair");
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
            else if (verification == "3")
            {

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
            string carroDesejo = Console.ReadLine().ToString().ToLower(); //Get carro para pesquisa
            while (!alugou) //Loop aluguel de carro
            {
                processadorAluguelDevolucao(ref alugou,ref carroDesejo, "alugar", "alugado", true, "indisponível");

            }
        }

        public static void menuDevolverCarro()
        {
            bool naoEnche = false;
            Console.Clear();
            header();
            Console.WriteLine("Lista dos carros:");
            listaCarros();
            separador(30);
            Console.WriteLine("Digite o modelo do carro para devolver"); //Pergunta o carro desejado
            string carroDesejo = Console.ReadLine().ToString().Replace(" ","").ToLower(); //Get carro para pesquisa
            processadorAluguelDevolucao(ref naoEnche, ref carroDesejo, "devolver", "devolvido", false, "disponível. Não é possível devolve-lo!" );
            
        }

        public static void processadorAluguelDevolucao(ref bool alugou, ref string carroDesejo, string txtAlugarDevolver, string txtPassado, bool setModo, string indisp)
        {
            var testeAlugou = pesquisarExistenciaDoCarro(carroDesejo);
            if (testeAlugou != null && testeAlugou == setModo)
            {
                alugou = atualizarStatusCarro(carroDesejo, txtAlugarDevolver, setModo);
                if (alugou == true)
                {
                    Console.Clear();
                    header();
                    Console.WriteLine($"\n * Veículo {txtPassado} com sucesso *");
                    separador(30);
                    Console.WriteLine("Lista dos veículos:");
                    listaCarros();
                    separador(30);
                    Console.WriteLine("Pressione uma tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    alugou = true;
                    Console.Clear();
                }
            }
            else if (testeAlugou != null && testeAlugou == !setModo)
            {
                separador(30);
                Console.WriteLine($"\n!!! Veículo {indisp} !!!\n");
                alugou = menuCarroIndisponivel(ref carroDesejo);
            }
            else
            {
                separador(30);
                Console.WriteLine("\n!!! Não possuímos este modelo !!!\n");
                alugou = menuCarroIndisponivel(ref carroDesejo);
            }
        }
    }
    
}
