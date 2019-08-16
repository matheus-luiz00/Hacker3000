using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static string[,] alunos;
        static void Main(string[] args)
        {
            baseDeDados();

            separador(70);
            Console.WriteLine("                            LISTA DE ALUNOS");
            separador(70);
            mostrarALunos();
            Console.WriteLine();
            separador(70);
            Console.WriteLine("Pressione ENTER para sair");
            Console.ReadLine();
        }

        public static void baseDeDados()
        {
            alunos = new string[20, 3]
            {
                {"Matheus", "19", "M"},
                {"Ana", "17", "F"},
                {"Samara", "23", "F"},
                {"Lucas", "21", "M"},
                {"Samuel", "18", "M"},
                {"Otavio", "17", "M"},
                {"Belo", "22", "M"},
                {"Xuxa", "20", "F"},
                {"Enzo", "19", "M"},
                {"Adriana", "16", "F"},
                {"Tatiana", "25", "F"},
                {"Rodrigo", "24", "M"},
                {"Pamela", "18", "F"},
                {"Elisa", "19", "F"},
                {"Santos", "23", "M"},
                {"Vanessa", "20", "F"},
                {"George", "17", "M"},
                {"Cardoso", "21", "M"},
                {"Felipa", "26", "F"},
                {"Eliéu", "16", "M"}
            };
        }

        public static void mostrarALunos()
        {
            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                if(alunos[i,2] == "M")
                {
                    Console.WriteLine($"Aluno: {alunos[i,0]} \t\t| Idade: {alunos[i, 1]} anos \t| Sexo: Masculino");
                }
                else
                {
                    Console.WriteLine($"Aluno: {alunos[i, 0]} \t\t| Idade: {alunos[i, 1]} anos \t| Sexo: Feminino");
                }
                
            }
        }

        public static void separador(int x)
        {
            string xxx = new string('-', x);
            Console.WriteLine(xxx);
        }
    }
}
