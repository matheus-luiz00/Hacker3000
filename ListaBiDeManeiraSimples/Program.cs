using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeNomes = new string[5, 2];

            CarregarInformacoesEListarElasEmTelas(listaDeNomes);


            Console.WriteLine("Informe o ID do registro a ser pesquisado:");
            PesquisandoInformacoesNaNossaLista( listaDeNomes, Console.ReadLine());

            Console.ReadLine();

        }

        public static void CarregarInformacoesEListarElasEmTelas( string[,] arrayBi)
        {
            

            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                arrayBi[i, 0] = i.ToString();
                arrayBi[i, 1] = $"Salve_Guri_{i}";
            }

            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                Console.WriteLine($"ID: {arrayBi[i, 0]} | Nome: {arrayBi[i, 1]}");

            }
        }


        public static void PesquisandoInformacoesNaNossaLista( string[,] arrayBi, string pId)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                if (arrayBi[i,0] == pId)
                {
                    Console.WriteLine($"Informação escolhida: ID {arrayBi[i, 0]} | Nome {arrayBi[i, 1]}");
                    return;
                }
            }

            Console.WriteLine("Infelizmente a busca pelo id não resultou em nenhuma informação");
        }
    }
}
