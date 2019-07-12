using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static string[] receita;
        static void Main(string[] args)
        {
            carregarDados();
            header();

            Console.WriteLine("Bem Vindo!");
            Console.WriteLine("Você está pronto para aprender a fazer uma cuca deliciosa?");
            Console.WriteLine("Digite: (1) Sim (2) Não");
            if (Console.ReadLine() == "1")
            {
                iniciarReceita();
            }
            else Console.WriteLine("\n\nTchau, até a proxima!");

            

            Console.ReadLine();
        }

        public static void iniciarReceita()
        {
            for (int i = 0; i < receita.Length; ++i)
            {
                Console.Clear();
                header();
                Console.WriteLine($"\nPasso {i+1}: {receita[i]}\n\n");

                separador(60);
                Console.WriteLine("Pressione qualquer tecla para continuar\n");
                string read = Console.ReadKey().ToString();
                
            }

            Console.Clear();
            header();
            Console.WriteLine("Parabens, você concluiu sua receita. Bom apetite!");
            separador(60);
            Console.WriteLine("\n\nPressione qualquer tecla para finalizar");
        }

        static void carregarDados()
        {
            receita = new string[] { "Ligue o forno a 200º C","Separe os seguintes ingredientes para a massa da cuca: \n\n\t 3 xícaras de farinha de trigo \n\t 1½ xícaras de açúcar \n\t 3 ovos \n\t 2 colheres de sopa de manteiga ou margarina \n\t 2 colheres de sopa de fermento em pó químico para bolo",
                "Em uma batedeira bata as gemas de ovo com o açúcar\n\t e a margarina por 5 minutos ou até obter\n\t um creme fofo e claro. ",
                "Aos poucos, coloque a farinha de trigo peneirada\n\t e o leite, sempre batendo em velocidade baixa \n\t para incorporar bem os ingredientes, até que a\n\t massa esteja consistente.",
                "Bata as claras em neve com uma pitada de sal até\n\t ficarem bem consistente.",
                "Incorpore as claras na massa de cuca tradicional\n\t com a ajuda de uma espá-\n\ttula ou colher e delicadamente para não perder o ar.",
                "Por fim coloque o fermento e misture com uma espátula\n\t ou colher também.",
                "Massa pronta, hora de preparar a farofa.",
                "Separe os seguintes ingredientes para a farofa da cuca: \n\t 2 colheres de sopa de farinha de trigo\n\t 4 colheres de sopa de açúcar\n\t 4 colheres de sopa de manteiga amolecida\n\t 1 colher de chá de canela em pó",
                "Coloque os ingredientes da farofa em uma tigela\n\t e misture com as mãos até atingir\n\t consistência de farofa",
                "Unte uma forma com manteiga ou margarina", "Coloque a massa da farofa na forma untada", "Cubra a massa com a farofa", "Leve para assar por 35-40 minutos\n\t no forno pré-aquecido a 200ºC\n\t ou até dourar", "Quando a cuca estiver pronta retire-a do forno\n\t e deixe amornar um pouco antes\n\t de desenformar e cortar."};
        }

        public static void header()
        {
            separador(60);
            Console.WriteLine("                        Receitas da Vovó");
            separador(60);
        }
        public static void separador(int x)
        {
            string zaza = new string('-', x);
            Console.WriteLine(zaza);
        }
    }
}
