using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boleta.BoletasMesmo;

namespace BoletimPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Alunos alu = new Alunos();
            float media, freq;
            int escolha = -1;


            while (escolha != 0)
            {
                Console.Clear();
                escolha = MenuEscolha();
                switch (escolha)
                {
                    case 1:
                        {
                            Console.Clear();
                            MenuInserirAluno(alu);
                            break;
                        };
                    case 2:
                        {
                            MenuExibir(alu);
                            Console.ReadLine();
                            break;
                        };
                    case 3:
                        {
                            MenuExcluir(alu);
                            break;
                        };
                    case 4:
                        {
                            MenuAlterarAluno(alu);
                            break;
                        };
                    case 0:
                        {
                            escolha = 0;
                            break;
                        }
                }

            }
            
            


            Console.ReadKey();
        }

        static void MenuAlterarAluno(Alunos al)
        {
            Boletim bol = new Boletim();
            Console.WriteLine("Informe o id do aluno a ser excluido");
            int.TryParse(Console.ReadLine(), out int aute);
            al.AlterarDados(aute, bol.CalcMedia(PerguntaFloat("a Primeira Nota"), PerguntaFloat("a Segunda Nota"), PerguntaFloat("a Terceira Nota")) ,
                bol.CalcFreq(PerguntaFloat("o Total de AULAS"), PerguntaFloat("o Total de FALTAS")));

            Console.WriteLine("Operação Concluída");
            Console.ReadKey();
        }
        static void MenuExcluir(Alunos al)
        {
            Console.WriteLine("Informe o id do aluno a ser excluido");
            int.TryParse(Console.ReadLine(), out int aute);
            if(al.ExcluirAluno(aute))
            {
                Console.WriteLine("Aluno Exluído com sucesso");
            } else Console.WriteLine("Aluno já não existe");

            Console.ReadKey();
        }

        static void MenuExibir(Alunos al)
        {
            al.ListarAlunos();
        }

        static void MenuInserirAluno(Alunos al)
        {
            Boletim boleto = new Boletim();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Insira o ALUNO Nº "+(i+1));
                var nome = PerguntaString("o NOME");
                var media = boleto.CalcMedia(PerguntaFloat("a Primeira Nota"), PerguntaFloat("a Segunda Nota"), PerguntaFloat("a Terceira Nota"));
                Console.WriteLine();
                var freq = boleto.CalcFreq(PerguntaFloat("o Total de AULAS"), PerguntaFloat("o Total de FALTAS"));
                al.InserirDados(i, nome , media, freq);
                Console.Clear();

            }
        }

        static string PerguntaString(string perg)
        {
            Console.WriteLine($"Insira um valor para {perg}");
            return Console.ReadLine().ToString();
            
        }
        static float PerguntaFloat(string perg)
        {
            Console.WriteLine($"Insira um valor para {perg}");
            float.TryParse(Console.ReadLine(), out float retorno);
            return retorno;
        }

        static int MenuEscolha()
        {
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine("(1) Inserir Alunos");
            Console.WriteLine("(2) Exibir Alunos");
            Console.WriteLine("(3) Excluir Alunos");
            Console.WriteLine("(4) Alterar Alunos");
            Console.WriteLine("(0) Sair");
            Console.WriteLine("-------------------------");
            int.TryParse(Console.ReadLine(), out int a);
            return a;
        }
    }
}
