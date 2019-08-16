using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLista_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] lista = new string[10, 3];
            string esc = "0"; 

            while(esc != "4")
            {
                esc = MostrarMenuPrincipal();

                if (esc == "1") //inserir
                {
                    InserirDados(ref lista);
                    ExibirLista(lista);
                    Console.WriteLine("Pressione enter para continuar:");
                    Console.ReadLine();
                }
                if (esc=="2") //mostrar lista
                {
                    ExibirLista(lista);
                    Console.WriteLine("Pressione enter para continuar:");
                    Console.ReadLine();
                }
                if (esc == "3") //apagar
                {
                    ExibirLista(lista);
                    Console.WriteLine("Digite o id do registro para ser apagado:");
                    ApagarRegistro(lista, Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine("Registro apagado com sucesso");
                    ExibirLista(lista);

                    Console.WriteLine("Pressione enter para continuar:");
                    Console.ReadLine();

                }
                if (esc == "4") break;

                Console.Clear();
                Console.WriteLine("!! ESCOLHA UMA OPÇÃO VÁLIDA !!\n");

            }
        }

        public static void InserirDados(ref string[,] dados)
        {
            Console.Clear();
            for (int i = 0; i < dados.GetLength(0); i++)
            {
                if (dados[i, 0] != null) continue;


                dados[i, 0] = (i + 1).ToString();
                Console.WriteLine("Insira o nome de uma música: ");
                dados[i, 1] = Console.ReadLine();
                Console.WriteLine("Insira quem toca essa música:");
                dados[i, 2] = Console.ReadLine();



                Console.WriteLine("Você deseja inserir outro valor? (1) SIM (2) NÃO");
                if (Console.ReadKey().KeyChar.ToString() == "2")
                {
                    break;
                }

                
                Console.Clear();
            }
            AumentarLista(ref dados);
        }

        public static void ExibirLista(string[,] dados)
        {
            for (int i = 0; i < dados.GetLength(0); i++)
            {
                if (dados[i,0] != null)
                    Console.WriteLine($"ID: { dados[i, 0]}\t| Música:  {dados[i, 1]}\t| Banda:  {dados[i, 2]}");
            }
        }

        public static void AumentarLista(ref string[,] listaParaAumentar)
        {
            bool limiteDaLista = true;

            for (int i = 0; i < listaParaAumentar.GetLength(0); i++)
            {
                if (listaParaAumentar[i, 0] == null) limiteDaLista = false;
            }

            if (limiteDaLista)
            {
                var listaCopia = listaParaAumentar;
                listaParaAumentar = new string[listaParaAumentar.GetLength(0) + 5, 3];
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    listaParaAumentar[i, 0] = listaCopia[i, 0];
                    listaParaAumentar[i, 1] = listaCopia[i, 1];
                    listaParaAumentar[i, 2] = listaCopia[i, 2];
                }

            }
        }
        
        public static string MostrarMenuPrincipal()
        {
            Separador(70);
            Console.WriteLine("1) Adicionar registros\n2) Mostrar Lista\n3) Apagar um registro\n4) Sair");
            Separador(70);
            Console.WriteLine("Digite a opção desejada:");
            string escolha = Console.ReadLine().ToString();
            if (escolha == "1") return "1";
            if (escolha == "2") return "2";
            if (escolha == "3") return "3";
            if (escolha == "4") return "4";
            return "0";

        }
        
        public static void Separador(int vezes)
        {
            string txt = new string('-', vezes);
            Console.WriteLine(txt);
        }

        public static void ApagarRegistro(string[,] listaParaApagar, string id)
        {
            for (int i = 0; i < listaParaApagar.GetLength(0); i++)
            {
                if(listaParaApagar[i,0] == id)
                    listaParaApagar[i, 0] = listaParaApagar[i, 1]  = listaParaApagar[i, 2] = null;
            }
            string[,] troca = listaParaApagar;
            for (int i = 0; i < listaParaApagar.GetLength(0); i++)
            {
                if(listaParaApagar[i,0] == null && (i+1) < listaParaApagar.GetLength(0) && listaParaApagar[(i + 1), 0] != null)
                {
                    listaParaApagar[i, 0] = troca[(i + 1), 0];
                    listaParaApagar[i, 1] = troca[(i + 1), 1];
                    listaParaApagar[i, 2] = troca[(i + 1), 2];

                    listaParaApagar[(i + 1), 0] = listaParaApagar[(i + 1), 1] = listaParaApagar[(i + 1), 2] = null;
                }
            }

            for (int i = 0; i < listaParaApagar.GetLength(0); i++) if(listaParaApagar[i,0] != null) listaParaApagar[i, 0] = (i+1).ToString();
        }
    }
}
