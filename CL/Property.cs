using System;
using System.Collections.Generic;
using System.Text;

namespace CL
{
    public class Property
    {
        string Address { get; set; }
        decimal LastYearValue { get; set; }
        decimal MillageRate = 10.3M;
        decimal Exemption = 25000.0M;


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

        public override string ToString()
        {
            return ($"Property Address {Address} \n Last Year Assessed Value {LastYearValue} \n Currnet Value {this.CurrentAssessedValue(this.LastYearValue)} \n  Exemption: {this.Exemption} \n " +
                $"Taxable Value: {this.TaxableValue(this.CurrentAssessedValue(this.CurrentAssessedValue(this.LastYearValue)))}" );
        }
    }
}
