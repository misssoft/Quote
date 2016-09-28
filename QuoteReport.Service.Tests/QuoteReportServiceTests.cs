using System;
using NUnit.Framework;
using QuoteReport.Data;
using Rhino.Mocks;

namespace QuoteReport.Service.Tests
{
    [TestFixture]
    public class QuoteReportServiceTests
    {
        [TestCase(500000,true, "residential@test.com",        "The quote for residential@test.com property Value 500000. Total is 27500, including StampDuty - 25000 and Legal Fee - 2500")]
        [TestCase(500000,false, "nonresidential@test.com", "The quote for nonresidential@test.com property Value 500000. Total is 55000, including StampDuty - 50000 and Legal Fee - 5000")]
        public void GenerateQuoteReportService_Create_Reports(double value, bool residential, string email, string summary)
        {
            // Arrange
            var propertyRepoMock = MockRepository.GenerateMock<IProperties>();
            var emailerMock = MockRepository.GenerateMock<IEmailer>();
            
            var expectedProperty = new Property(value, residential, true, true, DateTime.Today, email);
            var expectedReportSummary = summary;

            propertyRepoMock.Stub(x => x.GetPropertiesForQuote()).Return(new[] { expectedProperty});
            
            //Act
            var service = new QuoteReportService(emailerMock,propertyRepoMock);
            service.GenerateQuoteReport();

            // Assert
            emailerMock.AssertWasCalled(x => x.Send(Arg<string>.Is.Equal(expectedProperty.ContactEmail), 
                Arg<Quote>.Matches(p=>p.ToString() == summary)));
        }
    }
}