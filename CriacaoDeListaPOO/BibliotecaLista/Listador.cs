using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeListaPOO.BibliotecaLista
{
    public class Listador
    {
        string[] lista;

        public Listador()
        {
            lista = new string[10];
            CarregarComDados();
        }

        public void AumentarLista(int novoTamanho)
        {
            lista = new string[novoTamanho];
        }
        public void CarregarComDados()
        {
            for (int i = 0; i < lista.Length; i++) //Preenche o array
            {
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
            }
        }

        /// <summary>
        /// Exibe os dados no array
        /// </summary>
        public void ExibirLista()
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Faz com que todos as casas do array fiquem Empty
        /// </summary>
        public void ApagarDados()
        {
            Console.WriteLine("Apagando dados..");
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = string.Empty;
            }
        }

        /// <summary>
        /// Faz com que o array na casa especificada fique Empty
        /// </summary>
        /// <param name="idApagar"></param>
        public void ApagarDados(int idApagar)
        {
            Console.WriteLine("Apagando dados no registro 5");
            for (int i = 0; i < lista.Length; i++)
            {
                if(i == idApagar)
                lista[i] = string.Empty;
            }
        }
    }
}
