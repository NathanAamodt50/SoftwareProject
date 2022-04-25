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
        public Customer Hold;
        public Value res;
        int Max = 10;

        public void filltable()
        {
            Table[0].fName = "Josh";
            Table[0].lName = "Aamodt";
            Table[0].phone_Num = "763-443-8105";
            Table[0].e_mail = "Josh_Aamodt@gmail.com";
            Table[0].drinker = false;
            Table[0].point = 1000;
            Table[1] = new Customer();
            Table[1].fName = "Nathan";
            Table[1].lName = "Aamodt";
            Table[1].phone_Num = "763-443-8105";
            Table[1].e_mail = "Nate_Aamodt50@gmail.com";
            Table[1].drinker = false;
            Table[1].point = 1000;
            Table[2] = new Customer();
            Table[2].fName = "Caleb";
            Table[2].lName = "Ockwig";
            Table[2].phone_Num = "763-443-8132";
            Table[2].e_mail = "Caleb.Ockwig@gmail.com";
            Table[2].drinker = true;
            Table[2].point = 600;
            Table[3].fName = "Cole";
            Table[3].lName = "Johnson";
            Table[3].e_mail = "John@applesauce.com";
            Table[3].phone_Num = "";
            Table[3].drinker = true;
            Table[3].point = 800;
            Table[4].fName = "Red";
            Table[4].lName = "Monsoon";
            Table[4].phone_Num = "322-651-651-6143";
            Table[4].e_mail = "red@colorman.com";
            Table[4].drinker = true;
            Table[4].point = 1000;
            Table[5].fName = "Darryl";
            Table[5].lName = "Phillman";
            Table[5].e_mail = "darryl@teamwoodgame.net";
            Table[5].phone_Num = "";
            Table[5].drinker = true;
            Table[5].point = 400;
            Table[6].fName = "Phil";
            Table[6].lName = "Davidson";
            Table[6].e_mail = "";
            Table[6].phone_Num = "4444-565-1234";
            Table[6].drinker = true;
            Table[6].point = 600;

            for (int i = 7; i < Table.Length; i ++)
            {
                Table[i].fName = "Soul";
                Table[i].lName = "Tar";
                Table[i].phone_Num = "911";
                Table[i].e_mail = "Soultar@gmail.com";
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
            Hold = new Customer();
            res = new Value();
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
                for (int c = 0; c < Table.Length; c++)
                {
                      temp = Table[c].fName + " " + Table[c].lName;
                      if (temp == text)
                      {
                        fullname = temp;
                        Hold.fName = Table[c].fName;
                        Hold.lName = Table[c].lName;
                        Hold.e_mail = Table[c].e_mail;
                        Hold.phone_Num = Table[c].phone_Num;
                        Hold.drinker = Table[c].drinker;
                        Hold.point = Table[c].point;
                    }
                }


                
                if (text == fullname)
                {
                    
                    this.Close();
                    SearchResults SR = new SearchResults(Hold);
                    SR.Show();
                }
                else if (textBox1.Text == "Gold" | textBox1.Text == "gold")
                {
                    this.Close();
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
