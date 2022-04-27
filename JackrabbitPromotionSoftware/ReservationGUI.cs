using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JackrabbitPromotionSoftware
{
    public partial class ReservationGUI : Form
    {
        public ReservationGUI()
        {
            InitializeComponent();
        }
        public string Fname, Lname;
        public Customer CurrentCustomer;
        public Reservation RES;
        private DateTime resTime;
        private int partySize;

        //Buttons to add
        //Create reservation
        //Show current reservations on the screen
        //View Profile

        public void createRez()
        {
            CurrentCustomer = new Customer(Fname, Lname);
            resTime = dateTimePicker3.Value;
            partySize = ((int)numericUpDown1.Value);
            RES = new Reservation(CurrentCustomer, resTime, partySize);


            
        }
        public void deleteRez()
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ReservationGUI_Load(object sender, EventArgs e)
        {

        }
        //Split Textbox name into first and last names
        public void button1_Click(object sender, EventArgs e)
        {
            string N = textBox1.Text;
            string[] split = N.Split(' ');
            Fname = split[0];
            Lname = split[1];
            createRez();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //View Reservation
        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        //View Created Reservation
        private void button2_Click(object sender, EventArgs e)
        {
            VRes R = new VRes(RES);
            R.Show();
        }

        private void SearchCoup_Click(object sender, EventArgs e)
        {
            SearchCoup S = new SearchCoup();
            S.Show();
            this.Hide();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI myForm = (GUI)Application.OpenForms["GUI"];
            myForm.Show();

        }

        public void DrawString()
        {
            System.Drawing.Graphics formGraphics = this.CreateGraphics();
            string drawString = "Sample Text";
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            float x = 150.0F;
            float y = 50.0F;
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
        }

     
        
    }
}
