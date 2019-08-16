using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CantinaGG.Classes
{
    class Aluno
    {
        int id;
        string nome;
        double carteira;

        public Aluno(int idAl, string nm, double saldo)
        {
            id = idAl;
            nome = nm;
            carteira = saldo;
        }


        public bool Pagar(double valor)
        {
            if (carteira >= valor)
            {

                carteira -= valor;
                return true;
            }
            return false;
        }


        public double Carteira{ get { return carteira; } }
    }
}
