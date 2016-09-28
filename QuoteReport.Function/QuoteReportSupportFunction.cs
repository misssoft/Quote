using QuoteReport.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteReport.Function
{
    public static class QuoteReportSupportFunction
    {
        public static void Send(string contactEmail, Quote body)
        {
            Console.Out.WriteLine("Sent Email to: {0}, Body: '{1}'", contactEmail, body.ToString());
        }

        public static Quote CalculateQuote(Property property)
        {
            var quote = new Quote(property);
            if (property.IsResidential)
            {
                quote.AdminFee = property.Value*0.005;
                quote.Stampduty = property.Value*0.05;
                quote.Total = quote.AdminFee + quote.Stampduty;
            }
            else
            {
                quote.AdminFee = property.Value * 0.01;
                quote.Stampduty = property.Value * 0.1;
                quote.Total = quote.AdminFee + quote.Stampduty;
            }
            return quote;
        }
       
        public static IEnumerable<Property> GetPropertiesForQuote()
        {
            yield return new Property(125000, true, true, false, DateTime.Today, "residential1@function.com");
            yield return new Property(250000, false,false, true, DateTime.Today, "commercialA@function.com");
            yield return new Property(500000, true,true, true, DateTime.Today, "residential2@function.com");
            yield return new Property(1000000, false, false, false, DateTime.Today, "commercialB@function.com");
        }
    }
}
