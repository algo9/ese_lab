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
    public partial class FormMain : Form
    {
        Form_agg fg;
        partite g = new partite();


        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_carica_Click(object sender, EventArgs e)
        {
            
            g.carica();
            visualizza();
        }

      void visualizza()
    {
        listView1.Items.Clear();
        ListViewItem x;
        for (int i = 0; i < g.ne; i++)
        {
            x = new ListViewItem((i + 1).ToString());
            x.SubItems.Add(g.tab[1,0].nome);
            x.SubItems.Add(g.tab[1,1].nome);
            x.SubItems.Add(g.tab[1,0].goal.ToString());
            x.SubItems.Add(g.tab[1, 1].goal.ToString());
            listView1.Items.Add(x);

        }
        
    }
      private void aggiornaToolStripMenuItem_Click(object sender, EventArgs e)
      {
          if (fg == null)
          {
              fg = new Form_agg();
              fg.risultatocambiato += aggiornapartite;
          }
          fg.Show();
      }
    

      void aggiornapartite(int r , int c) 
      {
          g.tab[r, c].goal++;
          visualizza();

      }

      
    }
    
  
}
