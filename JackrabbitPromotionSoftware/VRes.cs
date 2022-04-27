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
    public partial class VRes : Form
    {
        public Reservation Res;
        public VRes(Reservation RES)
        {
            Res = new Reservation(RES.res_Customer, RES.res_Time, RES.party_size);
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            label2.Text = "Name: " + Res.res_Customer.fName + " " + Res.res_Customer.lName + "\n" + "Date: " + Res.res_Time + "\n" + "Party Size: " + Res.party_size;
        }
    }
}
