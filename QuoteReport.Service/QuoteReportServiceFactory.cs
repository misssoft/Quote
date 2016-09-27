using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteReport.Service
{
    public static class QuoteReportServiceFactory
    {
        public static QuoteReportService CreateQuoteReportService()
        {
            return  new QuoteReportService(new Emailer(), new Properties());
        }
    }
}
