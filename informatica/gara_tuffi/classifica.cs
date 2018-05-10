using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;



namespace gara_tuffi
{
    class classifica
    {
        public const int DIM = 100;
        public const string nomef = "concorrenti.txt";

        //attributi
        concorrente[] tab;
        int ne;

        //costruttore
        public classifica() 
        {
            tab = new concorrente[DIM];
            ne = 0;

        }
        
        //carica
       public bool carica()
        {
            if (File.Exists(nomef)== false)
                return false;
           concorrente x;
            StreamReader sr = new StreamReader (nomef);
            string riga;
            while ((riga = sr.ReadLine()) != null)
            {
                string[] comp = riga.Split('\t');
                x.nome = comp[0];
                x.naz = comp[1];
                x.punti = 0;
                aggiungi(x);

            }
           
           
            sr.Close();
            return true;

        }

       public bool aggiungi(concorrente x) 
       {
           if (ne >= DIM)
               return false;
           tab[ne] = x;
           ne++;
           return true;


       }

    }
}
