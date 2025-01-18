using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion_principle
{
    internal class Program
    {

        //public class PdfReportGenerator
        //{
        //    public void Generate()
        //    {
        //        Console.WriteLine("PDF report generated :-).");
        //    }
        //}

        //public class ReportGenerator
        //{
        //    private PdfReportGenerator _pdfReportGenerator;


        //    public ReportGenerator()
        //    {
        //        // Direct dependency on PdfReport (low-level module)
        //        _pdfReportGenerator = new PdfReportGenerator();

        //    }

        //    public void GenerateReport()
        //    {
        //        _pdfReportGenerator.Generate();
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    // Client code
        //    ReportGenerator reportGenerator = new ReportGenerator();
        //    reportGenerator.GenerateReport();


        //    Console.ReadKey();
        //}


        public interface IReportGenerator
        {
            void Generate();

        }


        public class PdfReportGenerator : IReportGenerator
        {
            public void Generate()
            {
                Console.WriteLine("PDF report generated :-).");
            }
        }


        public class ExcelReportGenerator : IReportGenerator
        {
            public void Generate()
            {
                Console.WriteLine("Excel report generated :-).");
            }
        }


        public class WordReportGenerator : IReportGenerator
        {
            public void Generate()
            {
                Console.WriteLine("Word report generated :-).");
            }
        }


        public class CrystalReportGenerator : IReportGenerator
        {
            public void Generate()
            {
                Console.WriteLine("Crystal report generated :-).");
            }
        }


        public class ReportGenerator
        {
            private IReportGenerator _ReportGenerator;

            public ReportGenerator(IReportGenerator reportGenerator)
            {
                // Direct dependency on interface or abstact class.
                _ReportGenerator = reportGenerator;

            }

            public void GenerateReport()
            {
                _ReportGenerator.Generate();
            }

        }

        static void Main(string[] args)
        {
            ReportGenerator reportGenerator = new ReportGenerator(new PdfReportGenerator());
            reportGenerator.GenerateReport();


            reportGenerator = new ReportGenerator(new ExcelReportGenerator());
            reportGenerator.GenerateReport();

            reportGenerator = new ReportGenerator(new WordReportGenerator());
            reportGenerator.GenerateReport();


            reportGenerator = new ReportGenerator(new CrystalReportGenerator());
            reportGenerator.GenerateReport();

            Console.ReadKey();

        }
    }
}



