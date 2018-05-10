using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace convertitore_denaro
{
    public partial class Form1 : Form
    {
        const float conv_ed = 1.24f;
        const float conv_de = (1f/1.24f);

        public Form1()
        {
            InitializeComponent();
        }
        
        //conversione euro dollaro
        private void btn_conv_doll_Click(object sender, EventArgs e)
        {
            float euro= Convert.ToSingle(txt_euro.Text);
            float dollaro = euro * conv_ed;
            txt_dollari.Text = dollaro.ToString("0.00");

           


            
        }

        // conversione dollaro euro
        private void btn_conv_eu_Click(object sender, EventArgs e)
        {
            float dollaro = Convert.ToSingle(txt_dollari.Text);
            float euro = dollaro * conv_de;
            txt_euro.Text = euro.ToString("0.00");

           

        }
    }
}
