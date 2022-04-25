using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackrabbitPromotionSoftware
{
    public class Customer
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public string phone_Num { get; set; }
        public string e_mail { get; set; }
        public bool drinker { get; set; }
        public int point { get; set; }
        public Customer(string F = "", string L = "", string PN = "",string E = "", bool D = false, int P = 0)
        {
            fName = F;
            lName = L;
            e_mail = E;
            phone_Num = PN;
            drinker = D;
            point = P;
        }

        public Customer(Customer N)
        {
            fName = N.fName;
            lName = N.lName;
            phone_Num = N.phone_Num;
            e_mail = N.e_mail;
            drinker = N.drinker;
            point = N.point;
        }


    }
}
