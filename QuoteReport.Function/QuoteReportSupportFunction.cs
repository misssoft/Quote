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
        public static void Send(string toAddress, string body)
        {
            Console.Out.WriteLine("Sent Email to: {0}, Body: '{1}'", toAddress, body);
        }

        public static Quote CalculateQuote(ResidentialProperty property)
        {
            var quote = new Quote(property);
            return quote;
        }

        public static IEnumerable<ResidentialProperty> GetPropertiesForQuote()
        {
            yield return new ResidentialProperty(125000, true, false, DateTime.Today, "house1@function.com");
            yield return new ResidentialProperty(250000, false, true, DateTime.Today, "house2@function.com");
            yield return new ResidentialProperty(500000, true, true, DateTime.Today, "house3@function.com");
            yield return new ResidentialProperty(1000000, false, false, DateTime.Today, "house4@function.com");
        }
    }
}
