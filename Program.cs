using System;

namespace celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
           

            Console.WriteLine("informe numero:");
            numero = int.Parse(Console.ReadLine());

            //  Console.WriteLine("sucessor" + (numero+1));
            //  Console.WriteLine("antecessor :" + (numero-1));
            Console.WriteLine("O número digitado foi {0}, o Antecessor {1} e o Sucessor {2} e o Teste {3}", numero, numero -= 1, numero += 2, numero-=2);
        }
    }
}
