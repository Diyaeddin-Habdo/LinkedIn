using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    internal class Program
    {
        // ISP'nin ihlal edildiği durum
        //public interface IPrinter
        //{
        //    void Print(string content);
        //    void Scan();
        //    void Fax();

        //}

        //public class BasicPrinter : IPrinter
        //{
        //    public void Print(string content)
        //    {
        //        Console.WriteLine($"Printing: {content}");
        //    }

        //    public void Scan()
        //    {
        //        // BasicPrinter doesn't support scanning, but must implement this method
        //        throw new NotImplementedException();
        //    }

        //    public void Fax()
        //    {
        //        // BasicPrinter doesn't support faxing, but must implement this method
        //        throw new NotImplementedException();
        //    }
        //}


        //public class AdvancedPrinter : IPrinter
        //{
        //    public void Print(string content)
        //    {
        //        Console.WriteLine($"Printing: {content}");
        //    }

        //    public void Scan()
        //    {
        //        Console.WriteLine($"Scanning..");
        //    }

        //    public void Fax()
        //    {
        //        Console.WriteLine($"Faxing...");
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    IPrinter basicPrinter = new BasicPrinter();
        //    basicPrinter.Print("Hi, My Name is Diyaeddin Habdo");
        //    // basicPrinter.Scan();

        //    //basicPrinter.Fax();

        //    AdvancedPrinter advancedPrinter = new AdvancedPrinter();
        //    advancedPrinter.Print("Hi, My Name is Diyaeddin Habdo");
        //    advancedPrinter.Scan();
        //    advancedPrinter.Fax();

        //    Console.ReadKey();
        //}


        // ISP'nin uygulandığı durum
        public interface IPrint
        {
            void Print(string content);
        }
        public interface IScan
        {
            void Scan();
        }

        public interface IFax
        {

            void Fax();
        }
        public interface ICopy
        {
            void Copy();
        }
        public class BasicPrinter : IPrint
        {
            public void Print(string content)
            {
                Console.WriteLine($"Printing: {content}");
            }
        }
        public class AdvancedPrinter : IPrint, IFax, IScan, ICopy
        {
            public void Print(string content)
            {
                Console.WriteLine($"Printing: {content}");
            }
            public void Scan()
            {
                Console.WriteLine($"Scanning..");
            }
            public void Fax()
            {
                Console.WriteLine($"Faxing...");
            }
            public void Copy()
            {
                Console.WriteLine($"Copying...");
            }
        }
        static void Main(string[] args)
        {
            BasicPrinter basicPrinter = new BasicPrinter();
            basicPrinter.Print("Hi, My Name is Diyaeddin Habdo");
            AdvancedPrinter advancedPrinter = new AdvancedPrinter();
            advancedPrinter.Print("Hi, My Name is Diyaeddin Habdo");
            advancedPrinter.Scan();
            advancedPrinter.Fax();
            advancedPrinter.Copy();
            Console.ReadKey();
        }
    }
}


