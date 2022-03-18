using System;

namespace AmariVettori6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 8;
            int[] tempi = new int[dimensione];
            int tempomin = 999999999;
            for (int i = 0; i<dimensione; i++)
            {
                Console.WriteLine("Digita il tempo in secondi");
                tempi[i] = Convert.ToInt32(Console.ReadLine());
                if (tempomin > tempi[i])
                {
                    tempomin = tempi[i];
                }
            }
        }
    }
}
