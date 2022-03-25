using System;

namespace Prof_gol
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gol = new int[8];
            int maxgol = 0;
            int mingol = 1000;
            //ciclo di caricamento del vettore
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Gol giornata " + (i + 1) + ": ");
                //l'elemento del vettore di indice i: gol[i]
                gol[i] = Convert.ToInt32(Console.ReadLine());

                if(gol[i] > maxgol)
                {
                    maxgol = gol[i];
                }
                if (gol[i] < mingol)
                {
                    mingol = gol[i];
                }
            }
            //ciclo di visualizzazione del vettore
            for (int i = 0; i < 8; i++)
            {
                //gol[0]=3
                //gol[1]=2
                Console.WriteLine($"gol[{i}]={gol[i]}");
            }

            Console.WriteLine("Giornata migliore =" + maxgol);
            Console.WriteLine("Giornata migliore =" + mingol);
        }
    }
}
