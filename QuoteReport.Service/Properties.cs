using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteReport.Data;

namespace QuoteReport.Service
{
    public class Properties : IProperties
    {
        public IEnumerable<Property> GetPropertiesForQuote()
        {
            yield return new Property(125000, true, true, false, DateTime.Today, "residential1@function.com");
            yield return new Property(250000, false, false, true, DateTime.Today, "commercialA@function.com");
            yield return new Property(500000, true, true, true, DateTime.Today, "residential2@function.com");
            yield return new Property(1000000, false, false, false, DateTime.Today, "commercialB@function.com");
        }
    }
}
