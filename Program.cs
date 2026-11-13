using System;

namespace SolidRefactoringLab
{
    
    public interface IReportFormatter
    {
        void FormatReport();
    }

    
    public class PdfFormatter : IReportFormatter
    {
        public void FormatReport()
        {
            Console.WriteLine("Formatting report as a PDF...");
        }
    }

 
    public class WordFormatter : IReportFormatter
    {
        public void FormatReport()
        {
            Console.WriteLine("Formatting report as a Word Document...");
        }
    }

    
    public class PlainTextFormatter : IReportFormatter
    {
        public void FormatReport()
        {
            Console.WriteLine("Formatting report as plain text...");
        }
    }

    public class ReportManager
    {
        public string ReportData { get; set; }

        private IReportFormatter formatter;

        public ReportManager(IReportFormatter formatter)
        {
            this.formatter = formatter;
        }

        public void GenerateReport()
        {
            formatter.FormatReport();
        }
    }

    // REPORT SAVER
    public class ReportSaver
    {
        public void SaveToFile(string filename)
        {
            Console.WriteLine($"Saving report data to {filename}...");
        }
    }

    // MAIN PROGRAM
    class Program
    {
        static void Main(string[] args)
        {
            IReportFormatter formatter = new PdfFormatter();

            ReportManager manager = new ReportManager(formatter);

            manager.ReportData = "Quarterly Report";

            manager.GenerateReport();

            ReportSaver saver = new ReportSaver();

            saver.SaveToFile("Q1_Report.pdf");
        }
    }
}
