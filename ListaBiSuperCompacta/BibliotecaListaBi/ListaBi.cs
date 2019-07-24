using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiSuperCompacta.BibliotecaListaBi
{
    class ListaBi
    {
        string[,] listaBi;

        /// <summary>
        /// Construtor
        /// </summary>
        public ListaBi()
        {
            listaBi = new string[5, 2];
            CarregaListaBi();
        }

        public void CarregaListaBi()
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                listaBi[i, 0] = i.ToString();
                listaBi[i, 1] = $"Giomar_{i}";

                Console.WriteLine($"Id: {i} | Nome: Giomar_{i}");
            }
        }
        public void PesquisaLista(string idPesquisa)
        {
            for (int i = 0; i < listaBi.GetLength(0); i++)
            {
                if(listaBi[i,0] == idPesquisa)
                {
                    Console.WriteLine("Resultado encontrado com sucesso!");
                    Console.WriteLine($"Você pesquisou pelo registro:{listaBi[i,1]}");
                    return;
                }
            }
        }
    }
}
