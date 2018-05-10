using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gara_tuffi
{
    public class giudici
    {
        int [] voto = new int [6];
        public int getvoto()
        {
           int somma=0;
            voto[p_min]=0;
            voto[p_max]=0;
           for(int i=0; i < 6; i++)
           {
           somma=somma+voto[i];
           }
            return somma;
        }
       
        public void set(int i, int x)
        {
            voto[i]=x;
        }

        int p_min 
        {   
           get{

                int min=0;
                for(int i=1; i < 6; i++)
                {
                    if(voto[i]< voto[min] )
                       min = i;
                   
                }
                return min;
            }
        }


        int p_max
        {
            get
            {
                int m = 0;
                for (int i = 0; i < 6; i++)
                {
                    if (voto[i] > voto[m])
                        m = i;
                   
                }
                return m;
            } 

        }
    }
}
