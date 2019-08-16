using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaGG.Classes
{
    class Lanches
    {
        string[,] lanches = new string[5,2]
        {
            {"Pastel de flango", "5" },
            {"Pastel de carne", "5" },
            {"Misto Quente", "2.5" },
            {"Coxinha", "3" },
            {"Empadão de frango", "7" }

        };

        public bool Compra(int opcao, Aluno aluno)
        {
            if (opcao <= lanches.GetLength(0) && opcao >= 0)
            {
                double.TryParse(lanches[opcao, 1], out double valor);
                if (aluno.Carteira >= valor)
                {
                    aluno.Pagar(valor);
                    return true;
                }
            }
            return false;
        }

        public string[,] MostrarLanches()
        {
            return lanches;
        }



    }
}
