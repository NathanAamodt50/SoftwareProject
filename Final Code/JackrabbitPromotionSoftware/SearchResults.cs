using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JackrabbitPromotionSoftware
{
    public partial class SearchResults : JackrabbitPromotionSoftware.SearchCoup
    {
        public SearchResults()
        {
            InitializeComponent();
        }

        private void SearchResults_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SucessfullySent SS = new SucessfullySent();
            SS.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SucessfullySent SS = new SucessfullySent();
            SS.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SucessfullySent SS = new SucessfullySent();
            SS.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SucessfullySent SS = new SucessfullySent();
            SS.Show();
        }
    }
}
