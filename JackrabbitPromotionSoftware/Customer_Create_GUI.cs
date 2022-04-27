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
    public partial class Customer_Create_GUI : Form
    {
        public Customer_Create_GUI()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Create_GUI_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Customer.IsValidEmail(email_text.Text)==true)
            {
                if(Customer.IsValidPhone(phone_text.Text))
                {
                    if(pword1.Text == pword2.Text)
                    {
                        Customer C = new Customer(first_name_text.Text, last_name_text.Text, phone_text.Text, email_text.Text);
                        success_msg_1.Text = "Success! Account Created";
                        Error_msg_1.Text = "";
                    }
                }
            }

            else
            {
                success_msg_1.Text = "";
                Error_msg_1.Text = "Error: one or more of you inputs were incorrect";
                //oops you got an error.
                //do this later I guess.
            }
        }

        private void Error_msg_1_Click(object sender, EventArgs e)
        {

        }

        private void success_msg_1_Click(object sender, EventArgs e)
        {

        }
    }
}
