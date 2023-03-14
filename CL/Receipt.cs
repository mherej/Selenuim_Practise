using System;
using System.Collections.Generic;
using System.Text;

namespace CL
{
    public class Receipt
    {
        private int receiptNumber;
        private DateTime dateOfPurchase;
        private int customerNumber;
        private string customerName;
        private string customerAdderss;
        private string customerPhoneNumber;
        private int itemNumber;
        private string itemDescription;
        private decimal itemPrice;
        private int quantityPuchased;

        public Receipt(int recNum, DateTime dateofpur, int custNum, string custname, string custadd, string custphnr, int itnr, string itdesc, decimal itpr, int qty )
        {
            ReceiptNumber = recNum;
            dateOfPurchase = dateofpur;
            CustomerNumber = custNum;
            customerName = custname;
            customerAdderss = custadd;
            customerPhoneNumber = custphnr;
            ItemNumber = itnr;
            itemDescription = itdesc;
            ItemPrice = itpr;
            QuantityPuchased = qty;
        }


        // validations
        public int ReceiptNumber
        { get { return receiptNumber; } set { if (value > 0) { receiptNumber = value; } else { receiptNumber = 0; } } }
        public int CustomerNumber
        { get { return customerNumber;} set {if (value > 0) { customerNumber = value; } } }
        public int QuantityPuchased
        { get { return quantityPuchased; } set { if (value > 0) { quantityPuchased = value; } } }
        public int ItemNumber
        { get { return itemNumber; } set { if (value > 0 && value <= 9999) { itemNumber = value; } } }
        public decimal ItemPrice
        { get { return itemPrice; } set { if (value > 0 && value <= 9999) { itemPrice = value; } } }

        // methods

        public decimal TotalPrice()
        {
            var total =  itemPrice * quantityPuchased;
            return total;
        }

        public override string ToString()
        {
            return ($"Customer: - {customerName} \nPhone: - {customerPhoneNumber} \nTotal Purchase: - {this.TotalPrice().ToString()}");
        }


    }
}
