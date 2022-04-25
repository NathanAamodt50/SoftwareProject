using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JackrabbitPromotionSoftware
{
    public partial class SearchGold : JackrabbitPromotionSoftware.GUI
    {
        public string S { get; set; }
        public SearchGold(string status)
        {
            S = status;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SucessfullySent SS = new SucessfullySent();
            SS.Show();
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

        private void SearchGold_Load(object sender, EventArgs e)
        {
            label3.Text = "Rank: " + S;
        }
    }
}
