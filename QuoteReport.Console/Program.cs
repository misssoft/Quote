using QuoteReport.Function;

namespace QuoteReport.Console
{
    using QuoteReport.Service;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var service = QuoteReportServiceFactory.CreateQuoteReportService();
            service.GenerateQuoteReport();
            System.Console.ReadLine();

            var residentialFun = QuoteReportFunctionFactory.CreateReportFunction();
            residentialFun.Invoke();
            System.Console.ReadLine();
        }
    }
}
