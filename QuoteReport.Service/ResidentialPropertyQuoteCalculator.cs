using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteReport.Data;

namespace QuoteReport.Service
{
    public class ResidentialPropertyQuoteCalculator : IQuoteCalculator
    {
        public Quote CalculateQuote(ResidentialProperty property)
        {
            var quote = new Quote(property);
            return quote;
        }
    }
}
