using QuoteReport.Function;

namespace QuoteReport.Console
{
    using QuoteReport.Service;
    class Program
    {
       static void Main(string[] args)
        {
            var service = QuoteReportServiceFactory.CreateQuoteReportService();
            service.GenerateQuoteReport();
            System.Console.ReadLine();

            var function = QuoteReportFunctionFactory.CreateReportFunction();
            function.Invoke();
            System.Console.ReadLine();
        }
    }
}
