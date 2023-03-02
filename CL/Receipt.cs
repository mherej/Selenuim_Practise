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
            receiptNumber = recNum;
            dateOfPurchase = dateofpur;
            customerNumber = custNum;
            customerName = custname;
            customerAdderss = custadd;
            customerPhoneNumber = custphnr;
            itemNumber = itnr;
            itemDescription = itdesc;
            itemPrice = itpr;
            quantityPuchased = qty;
        }


        // validations
        public int ReceiptNumber { get { return receiptNumber;} set { if(receiptNumber < 0) { Console.WriteLine("The receipt number can not be less than zero");}  else { receiptNumber = value; } } }

        public int CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                if (customerNumber < 0)
                {
                    Console.WriteLine("The customer number can not be less than zero");
                }
                else
                {
                    customerNumber = value;
                }
            }

        }

        public int QuantityPuchased
        {
            get
            {
                return quantityPuchased;
            }
            set
            {
                if (quantityPuchased < 0)
                {
                    Console.WriteLine("The quantity purchased can not be less than zero");
                }
                else
                {
                    quantityPuchased = value;
                }
            }

        }
        public int ItemNumber
        {
            get
            {
                return itemNumber;
            }
            set
            {
                if (itemNumber < 0 && itemNumber > 9999)
                {
                    Console.WriteLine("The item number can not be less than zero and more than 9999");
                }
                else
                {
                    itemNumber = value;
                }
            }

        }
        public decimal ItemPrice
        {
            get
            {
                return itemPrice;
            }
            set
            {
                if (itemPrice < 0 && itemPrice > 9999)
                {
                    Console.WriteLine("The item price can not be less than zero and more than 9999");
                }
                else
                {
                    itemPrice = value;
                }
            }

        }

        // methods

        public decimal TotalPrice()
        {
            var total =  itemPrice * quantityPuchased;
            return total;
        }

        public override string ToString()
        {

            return ($"Customer: - {customerName} \n Phone: - {customerPhoneNumber} \n Total Purchase: - {this.TotalPrice()}");
        }


    }
}
