using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBebida
{
    class Program
    {
        static void Main(string[] args)
        {
            header();

            Console.WriteLine("Olá, bem vindo!");
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            int.TryParse(Console.ReadLine(),out int idade);
            if(idade >= 18)
            {
                respostaDezoito(nome);
            }
            else if ( idade < 18)
            {
                Console.WriteLine($"{nome.ToUpperInvariant()}Você não pode consumir bebidas alcoólicas, mas você pode pedir uma PEPSI. Pode ser? ;))");
            }
            else if (idade <= 0)
            {
                Console.WriteLine("Algo de estranho aconteceu, você realmente tem 0 anos? (1) Sim (2) Não");
                int r;
                int.TryParse(Console.ReadLine(), out r);
                if (r == 2)
                {
                    Console.WriteLine("Você digitou sua idade errado");
                }
                else  Console.WriteLine("Parabéns, Usuário");
            }

            Console.ReadLine(); 
        }

        public static void respostaDezoito(string nome)
        {
            string[] respostas = new string[3] {$"{nome}, você pode consumir bebidas alcoólicas AMBEV! Vai uma Skol ai?",
                $"{nome}, já que você pode consumir bebidas alcoólicas, que tal tomar um Chopp Brahma bem gelado? :))",
                $"Pra quem pode consumir bebidas alcoólicas como você, {nome}, uma Budweiser sempre cai bem. Bora tomar uma? ;))"};
            Random dado = new Random();
            int jogado = dado.Next(0, 3);
            Console.WriteLine(jogado);

            if(DateTime.Now.DayOfWeek.ToString() == "Friday" && jogado == 2)
            {
                Console.WriteLine($"Hey {nome}, SEXTOU!!!  \\o/  E claro, você pode consumir bebidas alcoólicas AMBEV, tipo uma Original! Que tal? ;))");
            }
            else Console.WriteLine(respostas[jogado]);
            

        }

        public static void header()
        {
            separador(60);
            Console.WriteLine("                       SISTEMA AMBEV");
            separador(60);
        }

        public static void separador(int times)
        {
            string barra = new String('-', times);
            Console.WriteLine(barra);
        }
    }
}
