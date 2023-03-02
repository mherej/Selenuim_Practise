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
            Assert.AreEqual(-10, rec.ReceiptNumber);

            // check assignments of the setters in the receipt class.
        }
    }
}
