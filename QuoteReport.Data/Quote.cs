using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteReport.Data
{
    public class Quote
    {
        public Property Property { get; set; }

        public double Stampduty { get; set; }

        public double AdminFee { get; set; }

        public double Total { get; set; }

        public Quote(Property property)
        {
            Property = property;
        }

        public override string ToString()
        {
            return $"The quote for {Property.ContactEmail} property Value {Property.Value}. Total is {Total}, including StampDuty - {Stampduty} and Legal Fee - {AdminFee}";
        }

    }
}
