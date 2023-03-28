using System;
using System.Collections.Generic;
using System.Text;

namespace CL
{
    public class Property
    {
        string Address { get; set; }
        decimal LastYearValue { get; set; }
        decimal MillageRate { get; set; }


        public Property(string address, decimal lastvalue)
        {
            Address = address;
            LastYearValue = lastvalue;
        }

        public decimal CurrentAssessedValue(decimal value)
        {
            return value + (1*.027M);
        }
          
        public decimal TaxableValue(decimal AssessedPropertyValue)
        {
            if (AssessedPropertyValue >= 25000)
            {
                return AssessedPropertyValue - 25000;
            }
            else
            {
                return AssessedPropertyValue;
            }     
        }

        public decimal TaxesDue(decimal taxableValue)
        {
            return (taxableValue / 1000)*10.3M;
        }


    }
}
