using System;
using System.Collections.Generic;
using NUnit.Framework;
using QuoteReport.Data;

namespace QuoteReport.Function.Tests
{
    [TestFixture]
    public class QuoteReportFunctionTests
    {
        [Test]
        public void GenerateQuoteReport_Create_Reports()
        {
            // arrange
            var expectedProperty = new Property(500000, true, true, true, DateTime.Today, "contact@funciton.com");
                
            var expectedReportSummary = "The quote for contact@funciton.com property Value 500000. Total is 27500, including StampDuty - 25000 and Legal Fee - 2500";

            Func<IEnumerable<Property>> getPropertyForQuote = () => new[] { expectedProperty};

            Func<Property, Quote> calculateQuote = quote => new Quote(expectedProperty) {LegalFee = 2500, Stampduty = 25000, Total = 27500};

            var actualToAddress = "";
            var actualBody = "";

            Action<string, string> sendEmail = (toAddress, body) => 
            {
                actualToAddress = toAddress;
                actualBody = body;
            };

            // act
            QuoteReportFunction.GenerateQuoteReport(getPropertyForQuote, calculateQuote, sendEmail);

            // assert
            Assert.AreEqual(expectedProperty.ContactEmail, actualToAddress);
            Assert.AreEqual(expectedReportSummary, actualBody);
        }
    }
}