using CriacaoDeListaPOO.BibliotecaLista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeListaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Listador lista = new Listador();

            lista.CarregarComDados();

            lista.ExibirLista();
            lista.ApagarDados();
            lista.ExibirLista();
            lista.AumentarLista(50);
            lista.CarregarComDados();

            lista.ExibirLista();
            Console.ReadKey();
        }
    }
}
