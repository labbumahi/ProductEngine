using ProductEngine.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEngine.Payment_Hub
{
    public class Paymenthub
    {

        public static IPayment GetPayment(int obj)
        {
            IPayment _payment;
            if (obj == Payment_constant.Paymenttype.Book.GetHashCode())
            {
                _payment = new BookPayment();
            }
            else if (obj == Payment_constant.Paymenttype.PhysicalProduct.GetHashCode())
            {
                _payment = new Paymentforphysicalpayment();

            }
            else if (obj == Payment_constant.Paymenttype.MembershipActivate.GetHashCode())
            {
                _payment = new Membership_activatepayment();

            }
            else if (obj == Payment_constant.Paymenttype.MembershipUpgrade.GetHashCode())
            {
                _payment = new Membership_Upgrade();

            }
            else if (obj == Payment_constant.Paymenttype.Video.GetHashCode())
            {
                _payment = new videopayment();

            }

            else
            {
                _payment = null;
            }
            return _payment;
        }
    }
}
