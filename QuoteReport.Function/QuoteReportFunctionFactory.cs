using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteReport.Function
{
    public static class QuoteReportFunctionFactory
    {
        public static Action CreateReportFunction()
        {
            return () => QuoteReportFunction.GenerateQuoteReport(
                QuoteReportSupportFunction.GetPropertiesForQuote,
                QuoteReportSupportFunction.CalculateQuote,
                QuoteReportSupportFunction.Send
            );
        }
    }
}
