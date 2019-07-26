using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarJoinhaClassMesmo
{
    public class AquiMostraJoinha
    {

        public void MetodoInicialDoJoinha()
        {
            Console.WriteLine("Aqui está inicial, pro joinha");
        }

        public void MetodoDoisPontoZero(bool eQuinta)
        {
            if (eQuinta) Console.WriteLine("Caraca mermão");
            else Console.WriteLine("AIaiAIaiAIaiAI");
        }

        public string[] TesteUmOperadorLegal()
        {
            return new string[2] { "Teste 1", "Teste 2" };
        }
    }
}
