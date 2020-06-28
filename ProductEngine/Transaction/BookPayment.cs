using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEngine.Transaction
{
    public class BookPayment:IPayment
    {
        private bool CommisionToAgent()
        {
            Console.WriteLine("Commssion to agent paid successfully");
            return true;
        }
        public bool Payment()
        {
            return Generateduplicatepackingslip();
        }

        public bool Generateduplicatepackingslip()
        {
            Console.WriteLine("Created Duplicate Packaging slip for royalty successfully");

            return CommisionToAgent();
        }
    }
}
