using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteReport.Service
{
    public class Emailer : IEmailer
    {
        public void Send(string toAddress, string body)
        {
            Console.Out.WriteLine("Sent Email to: {0}, Body: '{1}'", toAddress, body);
        }
    }
}
