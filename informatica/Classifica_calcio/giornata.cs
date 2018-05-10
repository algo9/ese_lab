using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace GiornataSerieA
{
    class giornata
    {
        const string nomef = "partite.txt";
        public Squadra[,] part;
        public giornata()
        {
            part = new Squadra[10, 2];
        }
        public void goal(int r, int c)
        {
            part[r, c].goal++;
        }
        public void set(int r, int c, int x)
        {
            part[r, c].goal = x;
        }
        public bool carica()
        {
            if (File.Exists(nomef) == false)
            {
                return false;
            }
            StreamReader sr = new StreamReader(nomef);
            int r = 0, c = 0;
            string squadra;
            while ((squadra = sr.ReadLine()) != null)
            {
                part[r, c].nome = squadra;
                part[r, c].goal = 0;
                c++;
                if (c > 1)
                {
                    c = 0;
                    r++;
                }

            }
            sr.Close();
            return true;
        }

    }
}
