using System;
using NUnit.Framework;
using QuoteReport.Data;
using Rhino.Mocks;

namespace QuoteReport.Service.Tests
{
    [TestFixture]
    public class QuoteReportServiceTests
    {
        [Test]
        public void GenerateQuoteReport_Create_Reports()
        {
            // Arrange
            var propertyRepoMock = MockRepository.GenerateMock<IProperties>();
            var quoteCalculatorMock = MockRepository.GenerateMock<IQuoteCalculator>();
            var emailerMock = MockRepository.GenerateMock<IEmailer>();

            var expectedProperty = new Property(500000, true, true, true, DateTime.Today, "owner1@test.com");
            var expectedReportSummary = "The quote for owner1@test.com property Value 500000. Total is 27500, including StampDuty - 25000 and Legal Fee - 2500";

            propertyRepoMock.Stub(x => x.GetPropertiesForQuote()).Return(new[] { expectedProperty});

            quoteCalculatorMock.Stub(x => x.CalculateQuote(expectedProperty)).Return(new Quote(expectedProperty) {LegalFee = 2500, Stampduty = 25000, Total = 27500});

            //Act
            var service = new QuoteReportService(emailerMock,quoteCalculatorMock,propertyRepoMock);
            service.GenerateQuoteReport();

            // Assert
            emailerMock.AssertWasCalled(x => x.Send(expectedProperty.ContactEmail, expectedReportSummary));
        }
    }
}