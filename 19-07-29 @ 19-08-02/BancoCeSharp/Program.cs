using BancoCeSharp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta accountUser = new Conta();


            //Pega o valor para saque do usuario
            Console.WriteLine($"Saldo atual disponível: {accountUser.MostrarSaldo()}");
            Console.WriteLine("Informe o valor para saque:");
            double.TryParse(Console.ReadLine(), out double valorSacar);



            //Realiza o saque, se possível
            if (valorSacar > 0)
                if (accountUser.Sacar(valorSacar))
                    Console.WriteLine("Saque realizado com sucesso");
                else
                    Console.WriteLine("Operação não realizada");
            


            //Mostra o saldo para o usuário
            Console.WriteLine($"Saldo atual disponível: {accountUser.MostrarSaldo()}");
            Console.ReadKey();
        }
    }
}
