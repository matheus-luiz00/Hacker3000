using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertAndRemoveInList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDeDados = new string[2, 5];
            Console.WriteLine("Iniciando o Sistema");

            string escolha = ApresentaMenuInicial();
            while (escolha != "9")
            {
                switch (escolha)
                {
                    case "1": { InserirValoresNaLista(ref baseDeDados); } break; //Inserir registro
                    case "2": { MostrarInformacoes(baseDeDados); } break; //Listar registros ativos
                    case "3": { RemoverInformacoes(ref baseDeDados); } break; //Remover
                    case "4": { MostrarInformacoes(baseDeDados, "true"); } break; //Listar registros inativos
                    case "5": { return; } //Sair
                }
            }
        }

        public static string ApresentaMenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inserir um novo registro");
            Console.WriteLine("2 - Listar lista");
            Console.WriteLine("3 - Remover um registro");
            Console.WriteLine("4 - Listar Registros inativos");
            Console.WriteLine("5 - Sair do Sistema");
            Console.WriteLine("Digite o número da opção desejada");
            return Console.ReadLine();
        }

        public static void InserirValoresNaLista(ref string[,] baseDeDados)
        {
            Console.WriteLine("--------------Inserindo Valores Na Lista--------------");
            Console.WriteLine("Informe um nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a idade");
            var idade = Console.ReadLine();

            AumentaTamanhoLista(ref baseDeDados);

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null) continue;

                baseDeDados[i, 0] = i.ToString(); ;
                baseDeDados[i, 1] = nome;
                baseDeDados[i, 2] = idade;
                baseDeDados[i, 3] = "true";
                baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                AumentaTamanhoLista(ref baseDeDados);
                break;
            }

            Console.WriteLine("Registro cadastrado com sucesso");
            Console.WriteLine("Para voltar ao menu inicial pressione ENTER");
            Console.ReadLine();
        }

        public static void MostrarInformacoes(string[,] baseDeDados, string mostrarRegistrosNAtivos = "false")
        {
            if (mostrarRegistrosNAtivos == "true") Console.WriteLine("Apresentação das informações dentro da base de dados");
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 3] != mostrarRegistrosNAtivos) Console.WriteLine($"ID: {baseDeDados[i,0]} - Nome: {baseDeDados[i, 1]} - Idade: {baseDeDados[i, 2]} - Data Alteração: {baseDeDados[i, 4]}");
            }
            Console.WriteLine("Resultado apresentado com sucesso");
            Console.WriteLine("Para voltar ao menu inicial pressione ENTER");
            Console.WriteLine();
        }

        public static void RemoverInformacoes(ref string[,] baseDeDados)
        {
            Console.WriteLine("Área de remoção de registro do sistema");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null) Console.WriteLine($"ID: {baseDeDados[i, 0]} - Nome: {baseDeDados[i, 0]} - Idade: {baseDeDados[i, 0]}");
            }

            Console.WriteLine("Informe o ID do registro a ser removido:");
            var id = Console.ReadLine(); ;

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null && baseDeDados[i,0] == id)
                {
                    baseDeDados[i, 3] = "false";
                    baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }

            Console.WriteLine("Operações finalizadas");
            Console.WriteLine("Para retornar ao menu inicial pressione ENTER:");
            Console.ReadLine();
        }

        public static void AumentaTamanhoLista(ref string[,] baseDeDados)
        {
            bool limiteDaLista = true;

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] == null) limiteDaLista = false;
            }

            if (limiteDaLista)
            {
                var listaCopia = baseDeDados;
                baseDeDados = new string[baseDeDados.GetLength(0) + 5, 5];
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    baseDeDados[i, 0] = listaCopia[i, 0];       //ID
                    baseDeDados[i, 1] = listaCopia[i, 1];       //Nome
                    baseDeDados[i, 2] = listaCopia[i, 2];       //Idade
                    baseDeDados[i, 2] = listaCopia[i, 3];       //Ativou ou desativo
                    baseDeDados[i, 2] = listaCopia[i, 4];       //
                }

                Console.WriteLine("O Tamanho da Lista foi atualizado");

            }
        }
    }
}
