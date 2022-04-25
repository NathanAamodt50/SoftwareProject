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

        private void SearchResults_Load(object sender, EventArgs e)
        {
            string Rank;
            string name = Table[res.val].fName + " " + Table[res.val].lName;
            int rankp =  Table[res.val].point/ 200;
            switch (rankp)
            {
                case 1:
                    Rank = "Bronze";
                    break;
                case 2:
                    Rank = "Silver";
                    break;
                case 3:
                    Rank = "Gold";
                    break;
                case 4:
                    Rank = "Diamond";
                    break;
                case 5:
                    Rank = "Platinum";
                    break;
                default:
                    Rank = "Unranked";
                    break;
            }

            label3.Text = "Name: " + name + "\n" + "Rank: " + Rank;
        }
    }
}
