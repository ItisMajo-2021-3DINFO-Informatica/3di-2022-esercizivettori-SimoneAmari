using System;

namespace AmariVettori3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = new int[30];
            Random generatore = new Random();
            int somma = 0;
            for (int i = 0; i < 30; i++)
            {
                numeri[i] = generatore.Next(0, 51);
                Console.WriteLine(numeri[i]);
                somma = somma + numeri[i];
            }

            int media = somma / 30;
            Console.WriteLine("La media è di: "+ media);
        }
    }
}
