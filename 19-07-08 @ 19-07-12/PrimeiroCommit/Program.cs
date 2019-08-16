using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrimeiroCommit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            //string[] arrayTest = new string[2] { "Valor 1", "Valor 2" };
            string[] dateList = new string[10000];
            DateTime firstTime = DateTime.Now;


            //Code
            for (int i = 0; i < dateList.Length; i++)
            {
                dateList[i] = DateTime.Now.ToString("yyyyMMddhhmmssfff");
                Console.WriteLine(dateList[i]);
            }

            /*
            foreach (var item in dateList)
            {
                Console.WriteLine(item);
            }*/
            Console.WriteLine((DateTime.Now - firstTime).ToString());

            Console.ReadLine();
        }
    }
}
