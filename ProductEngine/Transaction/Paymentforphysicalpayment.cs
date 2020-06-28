using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEngine.Transaction
{
    public class Paymentforphysicalpayment : IPayment
    {
        public  bool Payment()
        {
            return Createphysicalprodinvoice();
        }

        public bool Createphysicalprodinvoice()
        {
            Console.WriteLine("Invoice for Physical product successfully");
            return AgentCommision();
        }

        private bool AgentCommision()
        {
            Console.WriteLine("Agent commision paid successfully!!");
            return true;
        }
    }
}
