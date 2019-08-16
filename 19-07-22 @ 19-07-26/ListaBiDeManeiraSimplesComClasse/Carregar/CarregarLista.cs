using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimplesComClasse.Carregar
{
    class CarregarLista
    {
        string[,] listaDeNome;

        public CarregarLista()
        {
            listaDeNome = new string[10, 2];
        }

        public void CarregarInformacoesEListarElasEmTelas()
        {


            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                listaDeNome[i, 0] = i.ToString();
                listaDeNome[i, 1] = $"Salve_Guri_{i}";
            }

            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                Console.WriteLine($"ID: {listaDeNome[i, 0]} | Nome: {listaDeNome[i, 1]}");

            }
        }

        public string[,] ListaDeNome
        {
            get { return listaDeNome; }
        }





    }
}
