using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JackrabbitPromotionSoftware
{
    public partial class SearchCoup : JackrabbitPromotionSoftware.GUI
    {
        public SearchCoup()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(textBox1.Text == "Nathan Aamodt")
            {
                this.Hide();
                SearchResults SR = new SearchResults();
                SR.Show();
            }
            else if (textBox1.Text == "Platinum")
            {

            }
            else
            {
                NoRes NR = new NoRes();
                NR.Show();
                KeyPressEventHandler.Equals

            }
        }


    }
}
