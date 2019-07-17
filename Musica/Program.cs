using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TuTutuTuuuuu
{
    class Musica
    {

        static int c3 = 130;



        static int s4b = 466;
        static int d5 = 587;
        static int c5 = 523;
        static int d5_ = 622;
        static int f5 = 698;
        static int g5 = 784;
        static int s5b = 932;
        static int c6 = 1046;


        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora para começar: HH:mm");
            string start = Console.ReadLine();

            while ((DateTime.Now.ToString("HH:mm")) != start)
            {

            }

            //Thread baixo = new Thread(Bass);
            //baixo.Start();
            while (true)
            {
                //Pré compasso
                Console.Beep(c5, 100);
                Console.Beep(c5, 100);
                Console.Beep(d5_, 130);
                Console.Beep(g5, 450);

                //1 Bar
                Console.Beep(f5, 700);
                Console.Beep(c5, 930);

                //2 Bar
                Thread.Sleep(430);
                Console.Beep(c5, 100);
                Console.Beep(c5, 100);
                Console.Beep(s4b, 130);
                //3 Bar
                Console.Beep(d5, 450);
                Console.Beep(c5, 930);

                //4 Bar
                Thread.Sleep(600);
                Console.Beep(c5, 100);
                Console.Beep(c5, 100);
                Console.Beep(d5_, 130);
                Console.Beep(g5, 450);
                //5 BAR 
                Console.Beep(f5, 700);
                Console.Beep(c6, 930);

                Thread.Sleep(100);
                Console.Beep(c6, 100);
                Console.Beep(c6, 100);
                Console.Beep(s5b, 130);
                Console.Beep(g5, 450);
                Console.Beep(c6, 930);

                Thread.Sleep(500);
            }
        }

        static void Bass()
        {
            Thread.Sleep(780);
            //1 BAR
            Console.Beep(c3, 600);

            //Thread.Sleep(100);
            Console.Beep(c3, 200);
            Console.Beep(c3, 800);
        }
    }
}