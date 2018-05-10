using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_form
{
    public partial class FormMain : Form
    {
        FormDati fd; 
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_apri_Click(object sender, EventArgs e)
        {
            if (fd == null)
            {
                fd = new FormDati();
                fd.mi_chiudo += gestioneChiusura;
                fd.button_press += buttonepremuto;
            }
                
            fd.Show();
           
            
        }

        void gestioneChiusura()
        {
            fd = null;

        }

        void buttonepremuto() 
        {
            n++;
            textBox1.Text = n.toString();
        }
    }
}

