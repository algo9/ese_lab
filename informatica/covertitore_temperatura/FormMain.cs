using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace convertitore_temperatura
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }
        
        //conversione euro dollaro
        private void btn_conv_fa_Click(object sender, EventArgs e)
        {
            float ce = Convert.ToSingle(txt_celsius.Text);
            float fa =  (ce * 1.8f) + 32;
            txt_far.Text = fa.ToString("0.00");

           


            
        }

        // conversione dollaro euro
        private void btn_conv_ce_Click(object sender, EventArgs e)
        {
            float fa = Convert.ToSingle(txt_far.Text);
            float ce = (fa - 32) / 1.8f; 
            txt_celsius.Text= ce.ToString("0.00");

           

        }
    }
}
