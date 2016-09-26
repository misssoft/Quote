using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteReport.Data;

namespace QuoteReport.Service
{
    public class PropertyQuoteCalculator : IQuoteCalculator
    {
        public Quote CalculateQuote(Property property)
        {
            var quote = new Quote(property);
            if (property.IsResidential)
            {
                quote.LegalFee = property.Value * 0.005;
                quote.Stampduty = property.Value * 0.05;
                quote.Total = quote.LegalFee + quote.Stampduty;
            }
            else
            {
                quote.LegalFee = property.Value * 0.01;
                quote.Stampduty = property.Value * 0.1;
                quote.Total = quote.LegalFee + quote.Stampduty;
            }
            return quote;
         }
    }
}
