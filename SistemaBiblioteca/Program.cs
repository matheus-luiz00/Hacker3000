using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    class Program
    {
        //Variaveis
        //string[,] options = new string[2, 2] { { "1", "Alocar livro" }, { "2", "Sair do sistema" } };
        /*string[,] baseDeLivros = new string[4,3] {
            { "1", "Sherlock Homes", "Disponível" },
            { "2", "Introdução ao C#", "Disponível" },
            { "3", "Castelo Interior", "Disponível" },
            { "4", "1984", "Disponível" }};*/

        static string[,] baseDeLivros;

        // MÉTODO MAIN
        static void Main(string[] args)
        {
            carregarBaseDeDados(); //carrega a array com os livros e a disponibilidade
            bemVindo(); //Escreve um header de boas vindas

            if (menuInicial() == 1) //menuInicial chama as opções e caso ela for '1 - pesquisar livro' chama a pesquisa
            {
                Console.Clear();
                bemVindo();
                Console.WriteLine("\r\nMenu - Alocação de Livros");
                separador(40);
                Console.WriteLine("Digite o nome do livro a ser pesquisado:");

                string nomeLivroEscolhido = Console.ReadLine().ToLower();
                if (pesquisaLivroParaAlocacao(nomeLivroEscolhido))  //pesquisa o livro digitado e retorna true caso ele possa ser alocado
                {
                    Console.WriteLine("\nVocê deseja alocar este livro? (1) Sim | (2) Não");
                    if(Console.ReadKey().KeyChar.ToString() == "1")
                    {
                        alocarLivro(nomeLivroEscolhido);
                        Console.Clear();
                        bemVindo();
                        Console.WriteLine("\n !!! Livro Alocado com Sucesso !!!\n");
                        separador(30);

                    }
                    else Console.Clear();
                    
                    Console.WriteLine("\nListagem de livros:");
                    for (int i = 0; i < baseDeLivros.GetLength(0); i++)
                    {
                        Console.WriteLine($"Nome do Livro: {baseDeLivros[i,0]} | Disponível: {baseDeLivros[i,1]}");
                    }
                }
            } else
            {
                Environment.Exit(12);
            }
            


            Console.ReadKey();
        }

        // functions
        /// <summary>
        /// Escreve "-" n vezes
        /// </summary>
        /// <param name="n"></param>
        static void separador(int n)
        {
            string line = new string('-', n);
            Console.WriteLine(line);
        }
        /// <summary>
        /// Escreve no console uma mensagem de boas vindas
        /// </summary>
        static void bemVindo()
        {
            separador(60);
            Console.WriteLine("SEJA BEM VINDO AO SISTEMAS **MATLOCA** DE ALOCAÇÃO DE LIVROS");
            separador(60);
        }

        /// <summary>
        /// Metodo que mostra o conteúdo e as opções de escolha.
        /// </summary>
        /// <returns>Retorna o valor do menu escolhido em um tipo inteiro</returns>
        static int menuInicial()
        {
            Console.WriteLine("\nMenu Inicial");
            separador(30);
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar livro.");
            Console.WriteLine("2 - Sair do sistema");
            separador(30);
            Console.WriteLine("Digite o número desejado:");
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Método que carrega a base de dados dentro do sistema
        /// </summary>
        public static void carregarBaseDeDados() //DATABASE
        {

            baseDeLivros = new string[3, 2]
            {
                {"Sherlock Homes","Sim" },
                {"1984","Não" },
                { "Introdução ao C#", "Sim" }
            };
        }

        /// <summary>
        /// Método que pesquisa um livro da base de dados
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser pesquisado</param>
        /// <returns>Retorna true caso o livro esteja disponível</returns>
        public static bool pesquisaLivroParaAlocacao(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i, 0].ToLower().Contains(nomeLivro))
                {
                    Console.WriteLine($"\nO livro '{baseDeLivros[i, 0]}' pode ser alocado?: {baseDeLivros[i, 1]}");
                    return baseDeLivros[i, 1] == "Sim";
                    
                }
            }
            
            return false;
        }
        
        /// <summary>
        /// Set disponibilidade do livro para não
        /// </summary>
        /// <param name="nomeLivro">Nome do livro para ser 'setado'</param>
        public static void alocarLivro(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i,0])
                {
                    baseDeLivros[i, 1] = "Não";
                }
            }
        }
    }
}
