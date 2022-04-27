using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackrabbitPromotionSoftware
{
    //Uses Customer class to create a reservation for a specific Customer in database
    public class Reservation
    {
        public Customer res_Customer { get; set; }
        public DateTime res_Time { get; set; }
        public int party_size { get; set; }

        //Class Constructor
        public Reservation(Customer c, DateTime D, int p)
        {
            res_Customer = c;
            res_Time = D;
            party_size = p;

        }
        //copy constructor
        public Reservation( Reservation R)
        {
            res_Customer = R.res_Customer;
            res_Time = R.res_Time;
            party_size = R.party_size;
        }

    }
}
