using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteReport.Data;

namespace QuoteReport.Service
{
    public interface IEmailer
    {
        void Send(string contactAddress, Quote quote);
    }
}
