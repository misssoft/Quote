using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteReport.Service
{
    public class QuoteReportService : IQuoteReportService
    {
        private readonly IEmailer _emailer;
        private readonly IProperties _propertiesRepo;

        public QuoteReportService(IEmailer emailer, IProperties properties)
        {
            _emailer = emailer;
            _propertiesRepo = properties;
        }
        public void GenerateQuoteReport()
        {
            var properties = _propertiesRepo.GetPropertiesForQuote();
            foreach (var house in properties)
            {
                var propertyQuote = new PropertyQuote(house);
                var quote = propertyQuote.CalculateQuote();
                _emailer.Send(quote.Property.ContactEmail,quote.ToString());
            }
        }
    }
}
