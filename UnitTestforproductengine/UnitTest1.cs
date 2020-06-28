using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductEngine;
using ProductEngine.Payment_constant;
using ProductEngine.Payment_Hub;
using ProductEngine.Transaction;


namespace UnitTestforproductengine
{
    [TestClass]
    public class UnitTestpaymenttransaction
    { //
        [TestMethod] 
        public void payment_forphysicalproduct()
        {
            //arrange for physical product method
            int physicalproduct = Paymenttype.PhysicalProduct.GetHashCode();
            IPayment paymentobj = Paymenthub.GetPayment(physicalproduct);
            //Act
            bool result = paymentobj.Payment();
            //Asert
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void payment_forduplicatepackaging_book_royelty()
        {
            //arrange 
            int book = Paymenttype.Book.GetHashCode();
            IPayment paymentobj = Paymenthub.GetPayment(book);
            //Act
            bool result = paymentobj.Payment();
            //Asert
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void payment_forupgrademebrship()
        {
            //arrange 
            int memupgrade = Paymenttype.MembershipUpgrade.GetHashCode();
            IPayment paymentobj = Paymenthub.GetPayment(memupgrade);
            //Act
            bool result = paymentobj.Payment();
            //Asert
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void payment_forActivatemembership()
        {
            //arrange 
            int Activaemembeship = Paymenttype.MembershipActivate.GetHashCode();
            IPayment paymentobj = Paymenthub.GetPayment(Activaemembeship);
            //Act
            bool result = paymentobj.Payment();
            //Asert
            Assert.AreEqual(result, true);
        }
        [TestMethod]
        public void payment_forAddfreevideo()
        {
            //arrange 
            int video = Paymenttype.Video.GetHashCode();
            IPayment paymentobj = Paymenthub.GetPayment(video);
            //Act
            bool result = paymentobj.Payment();
            //Asert
            Assert.AreEqual(result, true);
        }
        
    }
}
