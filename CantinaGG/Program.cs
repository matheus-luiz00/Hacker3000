using CantinaGG.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaGG
{
    class Program
    {
        static void Main(string[] args)
        {
            Lanches comida = new Lanches();

            Console.WriteLine("Digite o seu nome");
            string nm = Console.ReadLine();
            Console.WriteLine("Digite o saldo de sua carteira");
            double.TryParse(Console.ReadLine(), out double saldo);

            Aluno aluno = new Aluno(1, nm, saldo);


            Console.Clear();

            var lista = comida.MostrarLanches();

            int comprarLanche = 1;
            while (comprarLanche != 2)
            {

            for (int i = 0; i < lista.GetLength(0); i++)
            {
                Console.WriteLine($"ID: {i} | {lista[i,0]} | R$ {lista[i,1]}");
            }


                Console.WriteLine("Digite o lanche desejado");
                int.TryParse(Console.ReadLine(), out int opcao);


                if (comida.Compra(opcao, aluno))
                    Console.WriteLine("Lanche comprado com sucesso");
                else
                    Console.WriteLine("Não foi possível comprar o lanche");
                Console.WriteLine($"Saldo atual: R${aluno.Carteira.ToString("N2")}");
                Console.WriteLine("Você deseja comprar outro lanche? (1) SIM (2) NÃO");
                int.TryParse(Console.ReadLine(), out comprarLanche);
                Console.Clear();
            }

        }
    }
}
