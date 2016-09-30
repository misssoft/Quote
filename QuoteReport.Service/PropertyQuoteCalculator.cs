using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteReport.Data;

namespace QuoteReport.Service
{
    public class PropertyQuoteCalculator
    {
        public Property Property { get; }
        public PropertyQuoteCalculator(Property property){
            Property = property;
        }
        public Quote CalculateQuote()
        {
            var quote = new Quote(Property);
            if (Property.IsResidential){
                quote.AdminFee = Property.Value * 0.005;
                quote.Stampduty = Property.Value * 0.05;
                quote.Total = quote.AdminFee + quote.Stampduty;
            }else{
                quote.AdminFee = Property.Value * 0.01;
                quote.Stampduty = Property.Value * 0.1;
                quote.Total = quote.AdminFee + quote.Stampduty;
            }
            return quote;
        }
    }
}
