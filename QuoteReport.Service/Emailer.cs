using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteReport.Data;

namespace QuoteReport.Service
{
    public class Emailer : IEmailer
    {
        public void Send(string contactEmail, Quote quote)
        {
            Console.Out.WriteLine("Sent Email to: {0}, Body: '{1}'", contactEmail, quote.ToString());
        }
    }
}
