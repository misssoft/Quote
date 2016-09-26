﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuoteReport.Data;

namespace QuoteReport.Service
{
    public interface IQuoteCalculator
    {
        Quote CalculateQuote(Property property);
    }
}
