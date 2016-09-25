using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteReport.Data
{
    public class ResidentialProperty
    {
        public double Value { get;  }
        public bool IsFreehold { get;  }
        public bool IsJoinedOwned { get; }
        public DateTime TrasactionDate { get;  }

        public string ContactEmail { get; }

        public ResidentialProperty(double value, bool isFreehold, bool isJoinedOwned, DateTime date, string email)
        {
            Value = value;
            IsFreehold = isFreehold;
            IsJoinedOwned = isJoinedOwned;
            TrasactionDate = date;
            ContactEmail = email;
        }
     }
}
