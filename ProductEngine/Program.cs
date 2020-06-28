using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using ProductEngine.Transaction;


namespace ProductEngine
{

    class Program
    {
        static void Main(string[] args)
        {
            int output;
            Console.WriteLine("Please Enter Order type:");
            Console.WriteLine("1: Phyiscal Product\n" +
                              "2: Book\n" +
                              "3: Memebership\n" +
                              "4: Upgrade to a Memebership\n" +
                              "5: Video\n");
            Console.WriteLine("********************************");
            var response = Console.ReadLine();
            if (Int32.TryParse(response, out output))
            {
                transactionprcess(output);
            }
            else
            {
                Console.WriteLine("Please enter a valid option Number!");
            }
            Console.Read();
        }

        private static void transactionprcess(int typeofpayment)
        {
            IPayment paymentresponse = Payment_Hub.Paymenthub.GetPayment(typeofpayment);
            if ((paymentresponse == null))
            {
                Console.WriteLine("invalid transaction type !!!");


            }

            else 
            {
                paymentresponse.Payment();
            
            }
        }
    }
}
