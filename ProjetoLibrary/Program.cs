using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeArquivosDoWindows;

namespace MyFirstExternalLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFiles filesDeFrangos = new GetFiles();

            var array1 = filesDeFrangos.RetornaArquivosDoMeuDocumentos();
            var array2 = filesDeFrangos.RetornaArquivosImagesFiles();
            var array3 = filesDeFrangos.RetornaArquivosGit();

            if (array1 != null)
            {
                Console.WriteLine("Documentos");
                for (int i = 0; i < array1.Length; i++)
                {
                    Console.WriteLine(array1[i]);

                }
            } else Console.WriteLine("Não foi possível completar a operação");
            Console.WriteLine();
            if (array2!= null)
            {
                Console.WriteLine("Images");

                for (int i = 0; i < array2.Length; i++)
                {

                    Console.WriteLine(array2[i]);
                }
            } else Console.WriteLine("Não foi possível completar a operação");
            Console.WriteLine();

            Console.WriteLine("Git");
            if (array3 != null)
            {
                
                for (int i = 0; i < array3.Length; i++)
                {
                    Console.WriteLine(array3[i]);
                }
            } else Console.WriteLine("Não foi possível completar a operação");
            
            Console.ReadKey();
        }
    }
}
