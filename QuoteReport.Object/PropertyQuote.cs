﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteReport.Object
{
    public class PropertyObject
    {
        public double Value { get; }
        public bool IsResidential { get; set; }
        public bool IsFreehold { get; }
        public bool IsJoinedOwned { get; }
        public DateTime TransactionDate { get; }

        public string ContactEmail { get; }

        public Property(double value, bool isResidential, bool isFreehold, bool isJoinedOwned, DateTime date, string email)
        {
            Value = value;
            IsFreehold = isFreehold;
            IsJoinedOwned = isJoinedOwned;
            TransactionDate = date;
            ContactEmail = email;
        }
    }
}
