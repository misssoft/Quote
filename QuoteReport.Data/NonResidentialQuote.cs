using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteReport.Data
{
    public class NonResidentialQuote
    {
        public NonResidentialProperty Property { get; set; }

        public double Stampduty { get; set; }

        public double LegalFee { get; set; }

        public double Total => Stampduty + LegalFee;

        public NonResidentialQuote(NonResidentialProperty property)
        {
            Property = property;
            Stampduty = property.Value * 0.03;
            LegalFee = property.Value * 0.01;
        }

        public override string ToString()
        {
            return $"The quote for {Property.ContactEmail} property Value {Property.Value}. Total is {Total}, including StampDuty - {Stampduty} and Legal Fee - {LegalFee}";
        }
    }
}
