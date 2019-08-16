using ListaBiDeManeiraSimplesComClasse.Carregar;
using ListaBiDeManeiraSimplesComClasse.Mostrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiDeManeiraSimplesComClasse
{
    class Program
    {
        static void Main(string[] args)
        {


            var carregaLista = new CarregarLista();
            carregaLista.CarregarInformacoesEListarElasEmTelas();

            var mostraLista = new MostrarLista();

            mostraLista.PesquisandoInformacoesNaNossaLista(carregaLista.ListaDeNome, "0");

            Console.ReadKey();
        }
    }
}
