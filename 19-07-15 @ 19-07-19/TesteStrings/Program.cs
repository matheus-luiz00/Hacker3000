using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] teste = new string[5, 3] {
                {"Matheus", "2000", "Azul"},
                {"Ana", "2001", "Verde"},
                {"Clarissa", "1999", "Vermelho"},
                {"Pedro", "2000", "Verde"},
                {"Cleison", "1990", "Preto"}
            };


            for (int i = 0; i < teste.GetLength(0); i++)
            {
                Console.WriteLine(String.Format("Nome: {0,-20} | Nasc: {1,-4} | Cor FAV: {2,-10}", teste[i, 0], teste[i, 1], teste[i, 2]));
            }
            Console.ReadLine();
        }
    }
}
