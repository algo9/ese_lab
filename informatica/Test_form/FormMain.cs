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
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_apri_Click(object sender, EventArgs e)
        {
            FormDati fd= new FormDati();
            //fd.Show();
            DialogResult dr = fd.ShowDialog();
            if (dr == DialogResult.OK)
                MessageBox.Show("vuoi salvare?"); 
            
        }
    }
}
