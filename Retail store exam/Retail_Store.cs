using Microsoft.VisualStudio.TestTools.UnitTesting;
using CL;
using System;

namespace Retail_store_exam
{
    [TestCategory("Retails Store Tests")]
    [TestClass]
    public class Retail_Store_unit_test
    {

        static DateTime dateOfPurchaase;

        [ClassInitialize]
        public static void Receipt_initialize (TestContext testContext)
        {
            dateOfPurchaase = new DateTime();
        }

        [TestMethod]
        [TestCategory("Negtive Input")]
        public void Invalid_Receitp_Number()
        {
            // arrange
            Receipt rec = new Receipt(-10, dateOfPurchaase, 1, "Jonny Bravo", "Los Angeles", "00123 234 345", 1, "Lopipop", 10.99M, 21);
            // act
            Assert.AreEqual(0, rec.ReceiptNumber);
        }

        [TestMethod]
        [TestCategory("Negtive Input")]
        public void Invalid_Customer_Number()
        {
            // arrange
            Receipt rec = new Receipt(-10, dateOfPurchaase, -1, "Jonny Bravo", "Los Angeles", "00123 234 345", 1, "Lopipop", 10.99M, 21);
            // act
            Assert.AreEqual(0, rec.CustomerNumber);
        }

        [TestMethod]
        [TestCategory("Negtive Input")]
        public void Invalid_Quntity()
        {
            // arrange
            Receipt rec = new Receipt(-10, dateOfPurchaase, 1, "Jonny Bravo", "Los Angeles", "00123 234 345", 10000, "Lopipop", 10.99M, 20000);
            // act
            Assert.AreEqual(0, rec.ItemNumber);
        }
    }
}
