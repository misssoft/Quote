using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteReport.Data
{
    public class Quote
    {
        public ResidentialProperty Property { get; set; }

        public double Stampduty { get; set; }

        public double LegalFee { get; set; }

        public double Total => Stampduty + LegalFee;

        public Quote(ResidentialProperty property)
        {
            Property = property;
            Stampduty = property.Value*0.05;
            LegalFee = property.Value*0.005;
        }

        public override string ToString()
        {
            return $"The quote for {Property.ContactEmail} property Value {Property.Value}. Total is {Total}, including StampDuty - {Stampduty} and Legal Fee - {LegalFee}";
        }

    }
}
