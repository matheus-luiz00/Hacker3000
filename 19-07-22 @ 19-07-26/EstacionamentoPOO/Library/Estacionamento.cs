using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoPOO.Library
{
    public class Estacionamento
    {
        string[,] registros = new string[5, 5];

        public void Entrada(string modelo, string placa)
        {
            for (int i = 0; i < registros.GetLength(0); i++)
            {
                if (registros[i, 1] != "-1")
                {
                    registros[i, 0] = (i + 1).ToString(); 
                    registros[i, 1] = modelo;
                    registros[i, 2] = placa;
                    registros[i, 3] = DateTime.Now.ToString("dd/MM/yyyy");
                    registros[i, 4] = "-1";
                    break;
                }
            }
        }

        public void Entrada(int id)
        {
            for (int i = 0; i < registros.GetLength(0); i++)
            {
                if (registros[i, 0] == id.ToString())
                {
                    registros[i, 3] = DateTime.Now.ToString("dd/MM/yyyy");
                    registros[i, 4] = "-1";
                    break;
                }
            }
        }

        public void Saida(int id)
        {
            for (int i = 0; i < registros.GetLength(0); i++)
            {
                if (id.ToString() != registros[i, 0]) continue;

                registros[i, 4] = DateTime.Now.ToString("dd/MM/yyyy");

            }
        }

        public void Listar()
        {
            for (int i = 0; i < registros.GetLength(0); i++)
            {
                Console.WriteLine(  string.Format(" {0,-3} | {1,-20} | {2,8} | {3,10} | {4}",
                    registros[i, 0], registros[i, 1], registros[i, 2], registros[i, 3], (registros[i, 4] != "-1")? registros[i, 4]:"NULO"));
            }
        }

        public void ListarSemSaida()
        {

            for (int i = 0; i < registros.GetLength(0); i++)
            {
                if (registros[i, 4] != "-1") continue;
                Console.WriteLine(  string.Format(" {0,-3} | {1,-20} | {2,8} | {3,10} | {4}",
                    registros[i, 0], registros[i, 1], registros[i, 2], registros[i, 3], (registros[i, 4] != "-1") ? registros[i, 4] : "NULO"));
            }
        }

        public void Listar(string pesq)
        {
            for (int i = 0; i < registros.GetLength(0); i++)
            {
                if (registros[i, 2] != pesq) continue;
                Console.WriteLine(string.Format(" {0,-3} | {1,-20} | {2,8} | {3,10} | {4}",
                    registros[i, 0], registros[i, 1], registros[i, 2], registros[i, 3], (registros[i, 4] != "-1") ? registros[i, 4] : "NULO"));
                return;
            }
            Console.WriteLine("Placa não encontrada");
        }
    }
}
