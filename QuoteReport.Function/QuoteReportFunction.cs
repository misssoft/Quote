using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteReport.Data;

namespace QuoteReport.Function
{
    public static class QuoteReportFunction
    {
        public static void GenerateQuoteReport(Func<IEnumerable<ResidentialProperty>> getPropertiesforQuote,
                                               Func<ResidentialProperty, Quote> calculateQuote,
                                               Action<string, string> sendEmail)
        {
            var properties = getPropertiesforQuote();
            foreach (var house in properties)
            {
                var quote = calculateQuote(house);
                sendEmail(quote.Property.ContactEmail, quote.ToString());
            }
        }
    }
}
