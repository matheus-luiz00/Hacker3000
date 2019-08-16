using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDeDois
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeLivros = new string[2, 2]
                {{"O pequeno Príncipe", "sim" },{"Sherlock Homes","não"} };
            
            for (int i = 0; i < 2; i++)
            {
                var nomeLivro = listaDeLivros[i,0];
                var disponivel = listaDeLivros[i,1];

                Console.WriteLine($"Nome do livro: {nomeLivro} Disponível: {disponivel}");

            }

            Console.ReadLine();
        }
    }
}
