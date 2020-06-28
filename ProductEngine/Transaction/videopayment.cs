using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEngine.Transaction
{
    public class videopayment : IPayment
    {
        public bool Payment()
        {
            return Generatepamentforvideoinvoice();
        }

        public bool Generatepamentforvideoinvoice()
        {
            Console.WriteLine("Generate invoice for Video packing");
            return this.Addfreevideoinvoice();
        }

        private bool Addfreevideoinvoice()
        {
            Console.WriteLine("Add free video invoice generation!");
            return true;
        }
    }
}
