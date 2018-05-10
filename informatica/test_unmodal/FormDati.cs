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
    public delegate void miohandle();
    public delegate void miohandleclick();

    public partial class FormDati : Form
    {
        public event miohandle mi_chiudo;
        public event miohandle button_press;

        public FormDati()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //devo recuperare i dati
            DialogResult = DialogResult.OK;
            if (mi_chiudo != null)
                mi_chiudo();    
            Close();
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //
            DialogResult = DialogResult.Cancel;
            if (mi_chiudo != null)
                mi_chiudo();    
            Close();
        }

        private void btn_premi_Click(object sender, EventArgs e)
        {
            if(button_press != null)
                button_press();
        }
    }
}
