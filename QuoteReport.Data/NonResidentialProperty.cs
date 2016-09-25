using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteReport.Data
{
    public class NonResidentialProperty
    {
        public double Value { get;  }
        public bool IsFreehold { get;  }
        
        public string ContactEmail { get; }

        public NonResidentialProperty(double value, bool isFreehold,  string email)
        {
            Value = value;
            IsFreehold = isFreehold;
            ContactEmail = email;
        }
     }
}
