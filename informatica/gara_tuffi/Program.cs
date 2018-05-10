using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
   
namespace gara_tuffi
{
     
    class Program
    {
       static giudici g = new giudici();
       static classifica c = new classifica();
       
        static void Main(string[] args)
        {


            concorrente X;
            char ch;
            
            if (c.carica() == false)
            {
                Console.WriteLine("file concorrenti mancante");
                Console.ReadKey();
                return;
            }

           do
           {
                Console.Clear();
                Console.WriteLine("[1] : svolgimento gara");
                Console.WriteLine("[2] : classifica finale");
                Console.WriteLine("[*] : fine");
                Console.Write("Selezione:");
                ch = Console.ReadKey().KeyChar;
                switch (ch) 
                {
                    case  '1':
                        gara();
                        
                        break;
                    case '2':

                        break;

                
                
                }
           }while(ch != '*');

        }

        static void gara() 
        {
            for (int i = 0; i < n_tuffi; i++ )
                Console.Clear();
                Console.WriteLine("{0} {1}", c.tab[i].nome, c.tab[i].naz);
                Console.WriteLine("punteggio: ");
                for (int k = 0; k < 6; k++)
                {
                    int v;
                    do
                    {
                        v =Convert
                    }
                }
                
        }
    }
}
