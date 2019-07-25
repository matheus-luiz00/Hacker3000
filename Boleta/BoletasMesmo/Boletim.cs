using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleta.BoletasMesmo
{
    public class Boletim
    {
        

        public float CalcMedia(float n1, float n2, float n3)
        {
            return (n1 + n2 + n3) / 3;

        }

        public float CalcFreq(float totAulas, float faltas)
        {
            return ((totAulas - faltas) / totAulas)*100;
        }

        public void PrintStatus(float media, float freq)
        {
            Console.WriteLine((media >= 7) ? "Média: ACIMA da Média" : "Média: ABAIXO da Média");
            Console.WriteLine((freq >= 75) ? "Frequência: ATINGIDA" : "Frequência: NÃO ATINGIDA");
        }

    }
}
