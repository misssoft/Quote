using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteReport.Data;

namespace QuoteReport.Service
{
    public class ResidentialProperties : IResidentialProperties
    {
        public IEnumerable<ResidentialProperty> GetPropertiesForQuote()
        {
            yield return new ResidentialProperty(125000, true,false, DateTime.Today, "house1@service.com");
            yield return new ResidentialProperty(250000, false, true,DateTime.Today, "house2@service.com");
            yield return new ResidentialProperty(500000,true,true,DateTime.Today,"house3@service.com");
            yield return new ResidentialProperty(1000000, false, false, DateTime.Today,"house4@service.com");
        }
    }
}
