using System;
using System.Collections.Generic;
using NUnit.Framework;
using QuoteReport.Data;

namespace QuoteReport.Function.Tests
{
    [TestFixture]
    public class QuoteReportFunctionTests
    {
        [TestCase(500000, true, "residential@test.com", "The quote for residential@test.com property Value 500000. Total is 27500, including StampDuty - 25000 and Legal Fee - 2500")]
        [TestCase(500000, false, "nonresidential@test.com", "The quote for nonresidential@test.com property Value 500000. Total is 55000, including StampDuty - 50000 and Legal Fee - 5000")]
        public void GenerateQuoteReportFunction_Create_Reports(double value, bool residential, string email, string summary)
        {
            // arrange
            var expectedProperty = new Property(500000, residential, true, true, DateTime.Today, email);

            var expectedReportSummary = summary;

            Func<IEnumerable<Property>> getPropertyForQuote = () => new[] { expectedProperty};

            var actualToAddress = email;
            var actualBody = summary;

            Action<string, string> sendEmail = (toAddress, body) => 
            {
                actualToAddress = toAddress;
                actualBody = body;
            };

            // act
            QuoteReportFunction.GenerateQuoteReport(getPropertyForQuote, QuoteReportSupportFunction.CalculateQuote, sendEmail);

            // assert
            Assert.AreEqual(expectedProperty.ContactEmail, actualToAddress);
            Assert.AreEqual(expectedReportSummary, actualBody);
        }
    }
}