using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionandoValoresEmUmaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables

            string[,] lista = new string[10,2];

            //code

            inserirRegistro(ref lista);

            Console.Clear();

            Console.WriteLine("Registros adicionados com sucesso! Segue a lista das informações adicionadas:");
            ExibirDados(lista);
            AumentaTamanhoLista(ref lista);
            //repete

            inserirRegistro(ref lista);
            Console.WriteLine("Registros adicionados com sucesso! Segue a lista das informações adicionadas:");
            ExibirDados(lista);

            Console.ReadKey();
        }

        public static void inserirRegistro(ref string[,] listaInserir)
        {
            for (int i = 0; i < listaInserir.GetLength(0); i++)
            {
                if (listaInserir[i, 0] != null) continue;

                listaInserir[i, 0] = (i+1).ToString();
                Console.WriteLine($"\nInforme um valor para colocar na posição {listaInserir[i,0]} da lista: ");
                listaInserir[i, 1] = Console.ReadLine();

                Console.WriteLine("Deseja inserir um novo registro (1) SIM (2) NÃO");
                var continuar = Console.ReadKey().KeyChar.ToString();
                
                if (continuar == "2")
                {
                    break;
                }

                Console.Clear();
            }
        }

        public static void ExibirDados(string[,] dados)
        {
            for (int i = 0; i < dados.GetLength(0); i++)
            {
                Console.WriteLine(string.Format("ID: {0}\t | Nome: {1}", dados[i, 0], dados[i, 1]));
            }
        }

        public static void AumentaTamanhoLista(ref string[,] listaDeNome)
        {
            bool limiteDaLista = true;

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                if (listaDeNome[i,0] == null) limiteDaLista = false;
            }

            if(limiteDaLista)
            {
                var listaCopia = listaDeNome;
                listaDeNome = new string[listaDeNome.GetLength(0) + 5, 2];
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    listaDeNome[i, 0] = listaCopia[i, 0];
                    listaDeNome[i, 1] = listaCopia[i, 1];
                }

                Console.WriteLine("O Tamanho da Lista foi atualizado");

            }
        }
    }
}
