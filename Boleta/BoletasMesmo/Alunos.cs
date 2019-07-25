using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boleta.BoletasMesmo
{
    public class Alunos
    {
        string[] alunos = new string[5];
        string[] situacao = new string[5];
        float[] frequencias = new float[5];
        float[] notas = new float[5];

        public Alunos()
        {
            for (int id = 0; id < notas.Length; id++)
            {
                alunos[id] = "-1";
                situacao[id] = "-1";
                notas[id] = -1;
                frequencias[id] = -1;
            }
        }

        public void InserirDados(int id, string nome, float media, float freq) 
        {
            if (alunos[id] == "-1")
            {
                alunos[id] = nome;
                situacao[id] = (media >= 7 && freq >= 75) ? "Aprovado" : "Reprovado";
                notas[id] = media;
                frequencias[id] = freq;
            }
        }

        public void ListarAlunos()
        {
            Console.WriteLine(" ID |       NOME      |  SITUAÇÃO  |  MÉDIA | FREQUÊNCIA");
            for (int id = 0; id < alunos.GetLength(0); id++)
            {
                Console.WriteLine(string.Format("{4,3} | {0,15} | {1,10} | {2,6:0.00} | {3}", alunos[id], situacao[id], notas[id], frequencias[id], id));
            }
        }

        public bool ExcluirAluno(int id)
        {
            if (alunos[id] == "-1") return false;


            alunos[id] = "-1";
            situacao[id] = "-1";
            notas[id] = -1;
            frequencias[id] = -1;
            return true;
            
            
        }

        public void AlterarDados(int id, float media, float freq)
        {
            if (alunos[id] != "-1")
            {

                situacao[id] = (media >= 7 && freq >= 75) ? "Aprovado" : "Reprovado";
                notas[id] = media;
                frequencias[id] = freq;
            }
        }

    }
}
