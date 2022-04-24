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
        public Customer[] Table;
        int Max = 10;
        public int val;

        public void filltable()
        {


            Table[0].fName = "Josh";
            Table[0].lName = "Aamodt";
            Table[0].phone_Num = "763-443-8105";
            Table[0].drinker = false;
            Table[0].point = 1000;
            Table[1] = new Customer();
            Table[1].fName = "Nathan";
            Table[1].lName = "Aamodt";
            Table[1].phone_Num = "763-443-8105";
            Table[1].drinker = false;
            Table[1].point = 1000;
            Table[2] = new Customer();
            Table[2].fName = "Caleb";
            Table[2].lName = "Ockwig";
            Table[2].phone_Num = "763-443-8132";
            Table[2].drinker = true;
            Table[2].point = 600;
          
           for(int i = 3; i < Table.Length; i ++)
            {
                Table[i].fName = "S";
                Table[i].lName = "T";
                Table[i].phone_Num = " sdf";
                Table[i].drinker = false;
                Table[i].point = 0;
            } 

        }
        public void InitializeTable()
        {
            for (int c = 0; c < Table.Length; c++)
            {
                Table[c] = new Customer();
            }
        }
        public SearchCoup()
        {
            Table = new Customer[Max];
            InitializeTable();
            filltable();
            InitializeComponent();
            
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            string fullname = "";
            //Only works if enter is pressed
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
            }
            if (e.Handled == true)
            {
                string text = textBox1.Text;
                string temp;
                //compares textbox input to initalized customers
                
                for(int c = 0; c < Table.Length; c++)
                {
                    temp = Table[c].fName + " " + Table[c].lName;
                    if (temp == text)
                    {
                        fullname = temp;
                    }
                }

               
                if (text == fullname)
                {
                    this.Hide();
                    SearchResults SR = new SearchResults();
                    SR.Show();
                }
                else if (textBox1.Text == "Gold" | textBox1.Text == "gold")
                {
                    this.Hide();
                    SearchGold SG = new SearchGold();
                    SG.Show();
                }
                else
                {
                    NoRes NR = new NoRes();
                    NR.Show();
                    e.Handled = false;
                }
            }
        }


    }
}
