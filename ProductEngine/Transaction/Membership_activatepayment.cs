using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEngine.Transaction
{
   public class Membership_activatepayment:IPayment
    {
        public bool ActivateMembership()
        {
            Console.WriteLine("Membership activated successfully!!");
            return this.EmailNotificationToOwner();
        }

        private bool EmailNotificationToOwner()
        {
            Console.WriteLine("e-mail sent to the owner for Membership Activation");
            return true;
        }

        public bool Payment()
        {
            return ActivateMembership();

        }
    }
}
