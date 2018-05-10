using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using GiornataSerieA;


namespace Classifica_calcio
{
    public partial class FormMain : Form
    {
        FormAgg fg;
        giornata g = new giornata();
        const string nomef = "partite.txt";

        public FormMain()
        {
            InitializeComponent();
            visualizza();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            g.carica();
            visualizza();
            
        }
        
        void visualizza() 
        {
            listView1.Items.Clear();
            ListViewItem item;
           
            for (int i = 0; i < 2; i++)
            {
                for (int y = 0; y < 10; i++)
                {
                    item = new ListViewItem((i + 1).ToString());
                    item.SubItems.Add(part + (i + 1).ToString());
                    item.SubItems.Add("squadra O" + (i + 1).ToString());
                    item.SubItems.Add("0");
                    item.SubItems.Add("0");
                    listView1.Items.Add(item);
                }
            }

        
        }

        private void btn_agg_Click(object sender, EventArgs e)
        {
            if (fg == null)
            {
                fg = new FormAgg();

            }
            fg.Show();
        }

       

    }   
}
