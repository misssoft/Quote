using System;
using System.Collections.Generic;
using NUnit.Framework;
using QuoteReport.Data;

namespace QuoteReport.Function.Tests
{
    [TestFixture]
    public class NonFunctionalQuoteReportFunctionTests
    {
        [Test]
        public void GenerateQuoteReport_Create_Reports()
        {
            // arrange
            var expectedProperty = new NonResidentialProperty(500000, true, "contact@funciton.com");
            var expectedReportSummary = "The quote for contact@funciton.com property Value 500000. Total is 20000, including StampDuty - 15000 and Legal Fee - 5000";

            Func<IEnumerable<NonResidentialProperty>> getPropertyForQuote = () => new[] { expectedProperty};

            Func<NonResidentialProperty, NonResidentialQuote> calculateQuote = quote => new NonResidentialQuote(expectedProperty);

            var actualToAddress = "";
            var actualBody = "";

            Action<string, string> sendEmail = (toAddress, body) => 
            {
                actualToAddress = toAddress;
                actualBody = body;
            };

            // act
            QuoteReportFunction.GenerateNonResidentialQuoteReport(getPropertyForQuote, calculateQuote, sendEmail);

            // assert
            Assert.AreEqual(expectedProperty.ContactEmail, actualToAddress);
            Assert.AreEqual(expectedReportSummary, actualBody);
        }
    }
}