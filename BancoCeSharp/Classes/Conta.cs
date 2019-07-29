using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp.Classes
{
    public class Conta
    {
        private double saldo = 0;
        public double Saldo { get { return saldo; } }

        public Conta()
        {
            saldo = 1000;
        }

        /// <summary>
        /// Metodo pasa sacar dinheiro de acordo com o saldo disponivel
        /// </summary>
        /// <param name="valor"></param>
        public bool Sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
        public double MostrarSaldo()
        {
            return saldo;
        }

        public void Depositar(double valor)
        {

        }
    }
}
