using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GiornataSerieA
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            giornata g = new giornata();
            if (g.carica() == false) 
            {
                Console.WriteLine("file non trovato");
                Console.ReadKey();
                return;
            }
            do
            {
                Console.Clear();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("{0}\t-\t{1}  {2}  {3}", g.part[i, 0].nome, g.part[i, 1].nome, g.part[i, 0].goal, g.part[i, 1].goal);
                }
                Console.Write("[1] : aggiorna; [*] : fine");
                 ch = Console.ReadKey().KeyChar;
                 switch (ch) 
                 {
                     case '1':
                         break;
                 }

            } while (ch != '*');


        }
    }
}
