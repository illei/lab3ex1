using System;

namespace lab3ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numar = int.Parse(Console.ReadLine());

            Console.WriteLine(sumaCifrelor(numar));
        }

       static int sumaCifrelor(int x)
        {
            int suma = 0;

            while (x != 0)
            {






                suma = suma + x % 10;

                x = x / 10;


            }
            
            return suma;
        }

       
    }
}
