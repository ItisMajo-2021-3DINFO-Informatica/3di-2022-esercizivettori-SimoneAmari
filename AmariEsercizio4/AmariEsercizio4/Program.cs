using System;

namespace AmariEsercizio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = new int[100];
            Random generatore = new Random();
            int numeromin = 4000;
            int numeromax = 0;
            for (int i = 0; i < 100; i++)
            {
                numeri[i] = generatore.Next(1000, 3001);
                Console.WriteLine(numeri[i]);

                if (numeromax < numeri[i])
                {
                    numeromax = numeri[i];
                }
                if (numeromin > numeri[i])
                {
                    numeromin = numeri[i];
                }
            }
            Console.WriteLine("Il minimo è: " + numeromin);
            Console.WriteLine("Il massimo è: " + numeromax);
        }
    }
}
