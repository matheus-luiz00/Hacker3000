using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Lanche> minhaLista = new List<Lanche>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe o nome do lanche:");
                var nm = Console.ReadLine(); 
                Console.WriteLine("Informe a quantidade:");
                int.TryParse(Console.ReadLine(), out int quant);
                Console.WriteLine("Informe o valor:");
                double.TryParse(Console.ReadLine(), out double vl);

                minhaLista.Add(new Lanche()
                {
                    Nome = nm,
                    Quantidade = quant,
                    Valor = vl
                });

                Console.Clear();
            }

            Console.WriteLine("Removendo item");

            foreach (Lanche item in minhaLista)
            {
                if (item.Quantidade == 2)
                {
                    minhaLista.Remove(item);
                    break;
                }
            }


            minhaLista.Remove(minhaLista.FirstOrDefault(x => x.Quantidade == 2));

            var meuItem = (from item in minhaLista
                           where item.Quantidade == 3
                           select item).ToList<Lanche>();


            foreach (var item in minhaLista)
            {
                Console.WriteLine($"Lanches disponíveis: {item.Nome}");
            }

            Console.ReadKey();
        }
    }
}
