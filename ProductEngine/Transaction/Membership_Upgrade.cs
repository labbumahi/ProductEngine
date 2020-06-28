using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEngine.Transaction
{
    public class Membership_Upgrade : IPayment
    {
        public bool Payment()
        {
            return updatemembership();
        }

        private bool updatemembership()
        {
            Console.WriteLine("Membership update Successfully!");
            return this.Emailnotification();
        }

        public bool Emailnotification()
        {
            Console.WriteLine("Email sent to owner Successfully!");
            return true;
        }
    }
}
