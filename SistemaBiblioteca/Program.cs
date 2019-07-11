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
            
            var opcaoMenuPrincipal = menuPrincipal();
            while (opcaoMenuPrincipal != 3)
            {
                if (opcaoMenuPrincipal == 1) //menuInicial chama as opções e caso ela for '1 - pesquisar livro' chama a pesquisa
                {
                    MenuAlocacao();
                }
                if (opcaoMenuPrincipal == 2)
                {
                    desalocarUmLivro();
                }
                opcaoMenuPrincipal = menuPrincipal();
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
        static void mostrarSejaBemVindo()
        {
            separador(60);
            Console.WriteLine("SEJA BEM VINDO AO SISTEMAS **MATLOCA** DE ALOCAÇÃO DE LIVROS");
            separador(60);
        }

        /// <summary>
        /// Metodo que mostra o conteúdo e as opções de escolha.
        /// </summary>
        /// <returns>Retorna o valor do menu escolhido em um tipo inteiro</returns>
        static int menuPrincipal()
        {
            Console.Clear();

            mostrarSejaBemVindo();

            Console.WriteLine("\nMenu Inicial");
            separador(30);
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar livro");
            Console.WriteLine("2 - Devolver Livro");
            Console.WriteLine("3 - Sair do sistema");
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
        public static void alocarLivro(string nomeLivro, bool alocar)
        {

            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (baseDeLivros[i,0].ToLower().Contains(nomeLivro))
                {
                    baseDeLivros[i, 1] = alocar?"Não":"Sim";
                }
                Console.Clear();
                mostrarSejaBemVindo();
                Console.WriteLine("\n !!! Livro atualizado com Sucesso !!!\n");
                separador(30);

            }
        } 

        /// <summary>
        /// Método que carrega o contexto do menu 1 (Alocar livro) da tela inicial
        /// </summary>
        public static void MenuAlocacao()
        {
            MostrarMenuInicialLivros("Alocação de Livros");

            string nomeLivroEscolhido = Console.ReadLine().ToLower();
            if (pesquisaLivroParaAlocacao(nomeLivroEscolhido))  //pesquisa o livro digitado e retorna true caso ele possa ser alocado
            {
                Console.WriteLine("\nVocê deseja alocar este livro? (1) Sim | (2) Não");
                alocarLivro(nomeLivroEscolhido, (Console.ReadKey().KeyChar.ToString() == "1"));
                

                mostrarListaDeLivros();
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Mpetodo que mostra a lista de livros
        /// </summary>
        public static void mostrarListaDeLivros()
        {
            Console.WriteLine("\nListagem de livros:");
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome do Livro: {baseDeLivros[i, 0]} | Disponível: {baseDeLivros[i, 1]}");
            }
        }

        public static void desalocarUmLivro()
        {
            MostrarMenuInicialLivros("Desalocar um livro");
            mostrarListaDeLivros();
            string nomeLivroEscolhido = Console.ReadLine().ToLower();
            if (!pesquisaLivroParaAlocacao(nomeLivroEscolhido))  //pesquisa o livro digitado e retorna true caso ele possa ser alocado
            {
                Console.WriteLine("\nVocê deseja devolver este livro? (1) Sim | (2) Não");
                alocarLivro(nomeLivroEscolhido, !(Console.ReadKey().KeyChar.ToString() == "1"));


                mostrarListaDeLivros();
                Console.ReadKey();
            }
            alocarLivro(nomeLivroEscolhido, false);
        }

        public static void MostrarMenuInicialLivros(string operacao)
        {
            Console.Clear();

            mostrarSejaBemVindo();

            Console.WriteLine($"\r\nMenu - {operacao}");
            separador(40);
            Console.WriteLine("Digite o nome do livro:");
        }
    }
}
