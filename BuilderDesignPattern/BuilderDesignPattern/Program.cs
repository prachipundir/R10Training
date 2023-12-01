namespace BuilderDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PDFReport pdfReport = new PDFReport();
            ReportDirector reportDirector = new ReportDirector();
            Report report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();
            Console.WriteLine("-------------------");
            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();
            Console.ReadKey();
        }
    }
}