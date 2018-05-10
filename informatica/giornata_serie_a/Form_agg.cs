using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace giornata_serie_a
{
    // delegato alla gestione del' evento cambio risultato 
    public delegate void CambioRis(int part, int sqad);
    public partial class Form_agg : Form
    {
        int par;
        int sq;
        
        public event CambioRis risultatocambiato;

        public Form_agg()
        {
            InitializeComponent();

        }

        private void btn_casa_Click(object sender, EventArgs e)
        {
            sq = 0;
            avvertimodifica();

        }

        private void btn_osp_Click(object sender, EventArgs e)
        {
            sq = 1;
            avvertimodifica();
        }

        void avvertimodifica()
        {
            par = Convert.ToInt32(nu_par.Value);
            if (risultatocambiato != null)
                risultatocambiato(par -1, sq);
        }
       

    }
}
