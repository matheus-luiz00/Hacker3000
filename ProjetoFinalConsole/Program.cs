using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeLivros = new string[5,5];

            string escolha = "-1";
            while (escolha != "0")
            {
                escolha = MenuEscolhaPrincipal();
                switch (escolha)
                {
                    case "1": { InserirLivros(ref baseDeLivros); }; break;        //Inserir registro
                    case "2": { ListarRegistros(baseDeLivros); }; break;          //Listar registros ativos
                    case "3": { ListarRegistros(baseDeLivros, "False");}; break;  //Listar registros inativos
                    case "4": { RemoverLivro(ref baseDeLivros); }; break;         //Remover registros
                    case "9": { return;}; //Sair
                }

            }
        }

        static void RemoverLivro(ref string[,] banco)
        {
            Console.Clear();
            Header();

            ListarRegistros(banco, "True", "False");

            Console.WriteLine("\nRemover Livro:");
            Console.WriteLine("Digite o ID do livro a ser removido: ");
            string id = Console.ReadLine();

            for (int i = 0; i < banco.GetLength(0); i++)
            {
                if (banco[i, 0] == id)
                {
                    banco[i, 3] = "False";
                    banco[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }

            Console.WriteLine("\nOPERAÇÃO CONCLUÍDA");
            Separador(60);
            Console.WriteLine("Pressione ENTER para voltar ao menu inicial");
            Console.ReadLine();
        }

        static void AumentarBanco(ref string[,] banco)
        {
            var bancoCheio = true;

            for (int i = 0; i < banco.GetLength(0); i++)
            {
                if (banco[i, 0] == null) bancoCheio = false;
            }
            if(bancoCheio)
            {
                var bancoCopia = banco;
                banco = new string[(banco.GetLength(0) + 5), 5];

                for (int i = 0; i < banco.GetLength(0); i++)
                {
                    banco[i, 0] = bancoCopia[i, 0];
                    banco[i, 1] = bancoCopia[i, 1];
                    banco[i, 2] = bancoCopia[i, 2];
                    banco[i, 3] = bancoCopia[i, 3];
                    banco[i, 4] = bancoCopia[i, 4];
                }
            }
        }

        /// <summary>
        /// Exibe uma lista com os livros no console. Ao depender do parâmetro disp mostra os livros disponíveis ou indisponíveis
        /// </summary>
        /// <param name="banco">Array com os livros</param>
        /// <param name="disp">Mortrar disponíveis ou indisponíveis</param>
        static void ListarRegistros(string[,] banco, string disp = "True", string mostrarHeaderMenu = "True")
        {
            if(mostrarHeaderMenu == "True")
            {
                Console.Clear();
                Header();
            }

            Console.WriteLine(" ID |                TÍTULO                |           AUTOR           | MODIFICADO");
            Separador(115);
            for (int i = 0; i < banco.GetLength(0); i++)
            {
                if (banco[i, 3] == disp)
                    Console.WriteLine(String.Format(" {0,2} | {1,-36} | {2,-25} | Modificado: {3}", banco[i, 0], banco[i, 1], banco[i, 2], banco[i, 4]));
            }

            if (mostrarHeaderMenu == "True")
            {
                Console.WriteLine("\nPressione ENTER para voltar ao menu");
                Console.ReadLine();
            }
        }

        static void InserirLivros(ref string[,] banco)
        {
            for (int i = 0; i < banco.GetLength(0); i++)
            {
                if (banco[i, 3] != null) continue; //Caso o registro contenha algum valor, segue para o próximo

                //Limpa a tela e coloca o header
                Console.Clear();
                Header();

                //Implementação da inserção do livro na base
                Console.WriteLine("*MENU - Inserir Novos Livros\n");
                Console.WriteLine("Digite o Título do livro: ");
                banco[i, 1] =  Console.ReadLine();

                Console.WriteLine("Digite o AUTOR do livro: ");
                banco[i, 2] =  Console.ReadLine();

                banco[i, 0] = i.ToString(); //Coloca um id para o livro
                banco[i, 3] = "True"; //'set' disponibilidade para true
                banco[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); //Data modificação

                AumentarBanco(ref banco); //Aumenta o banco de livros em 5 caso este esteja cheio


                Console.WriteLine("\nOPERAÇÃO CONCLUÍDA");
                Separador(60);
                Console.WriteLine("Deseja inserir outro livro?");
                Console.WriteLine("(QUALQUER) Sim | (0) Não");
                if (Console.ReadKey().KeyChar.ToString() == "0") break;

            }




        }

        static string MenuEscolhaPrincipal()
        {
            Console.Clear();
            Header();
            Console.WriteLine("Seja Bem Vindo,\n");
            Console.WriteLine("(1) Inserir Novos Livros");
            Console.WriteLine("(2) Listar Livros Disponíveis");
            Console.WriteLine("(3) Listar Livros Indisponíveis");
            Console.WriteLine("(4) Remover Livro");
            Console.WriteLine("(0) Sair");
            Separador(30);
            Console.WriteLine("Escolha a opção desejada:");
            return Console.ReadLine();
        }

        /// <summary>
        /// Exibe um header para o sistema
        /// </summary>
        static void Header()
        {
            Separador(115);
            Console.WriteLine("                                               SISTEMA BIBLIOTECA");
            Separador(115);
        }

        /// <summary>
        /// Exibe um divisão com o caractere '-'
        /// </summary>
        /// <param name="x">Tamanho da divisão</param>
        static void Separador(int x)
        {
            string txt = new string('-', x);
            Console.WriteLine(txt);
        }
    }
}
