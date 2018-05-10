using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace giornata_serie_a
{
    public  struct Squadra
    {
        public string nome;
        public int goal;
        


    }

    public class partite 
    {
        const string nomef = "partite.txt";
        public Squadra[,] tab;
        public int ne;

        public partite()
        {
            tab = new Squadra[10, 2];
            ne = 0;
        }

        public bool carica()
        {
            if (File.Exists(nomef) == false)
            {
                return false;
            }
            StreamReader sr = new StreamReader(nomef);
            
            string riga;
            while ((riga = sr.ReadLine()) != null)
            {
                string  [] pezzi = riga.Split('\t');
                tab[ne, 0].nome = pezzi[0];
                tab[ne, 0].goal = Convert.ToInt32(pezzi[2]);
                tab[ne, 1].nome = pezzi[1];
                tab[ne, 1].goal = Convert.ToInt32(pezzi[3]);
                ne++;
                
                

            }
            sr.Close();
            return true;
        }
    
    }
}
