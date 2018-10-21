using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class PrinterExecuter
    {
        static void Main(string[] args)
        {
            string makerName = "Canon Ink Jet Printer PIXUS";
            string model = "iP7230";
            Printer printer = Printer.GetInstance(makerName, model);
            bool sucess = false;
            //_____________________________________________________

            // Check the status of printer before printing.
            Console.WriteLine("Print the first time:");
            if (printer.PrinterStatus == Status.Available)
            {
                Console.WriteLine("1. The status is Available:");
                Console.WriteLine("     Before printing at the first time: ");
                Console.WriteLine("\t\t=>" + printer.GetInfo());
                printer.Print();
                Console.WriteLine("     After printing at the first time: ");
                Console.WriteLine("\t\t=>"+printer.GetInfo());
            }
            else
            {
                DisplayStatusOfPrinter(printer);
            }


            // Check the status of printer before printing.
            Console.WriteLine("Print the second time:");
            if (printer.PrinterStatus == Status.Available)
            {
                Console.WriteLine("2. The status is Available:");
                Console.WriteLine("     Before printing at the second time: ");
                Console.WriteLine("\t\t=>" + printer.GetInfo());
                printer.Print();
                Console.WriteLine("     After printing at the second time: ");
                Console.WriteLine("\t\t=>" + printer.GetInfo());
            }
            else
            {
                DisplayStatusOfPrinter(printer);
            }
            //_____________________________________________________

            Console.WriteLine("_________________________________________________________________________________________");

            Console.WriteLine("Print 50 papers:");
            if (printer.PrinterStatus == Status.Available)
            {
                Console.WriteLine("3. The status is Available:");
                Console.WriteLine("     Execute printing 50 papers: ");
                Console.WriteLine("\t\t=>" + printer.GetInfo());
                if (printer.Prints(50))
                {
                    Console.WriteLine("     After printing 50 papers: ");
                    Console.WriteLine("\t\t=>" + printer.GetInfo());
                }
                else
                {
                    DisplayStatusOfPrinter(printer);
                    Console.WriteLine("\t\t=>" + printer.GetInfo());
                    Console.WriteLine("\t\t=>"+(50-printer.TotalPrintedSheets) +" papers left have not printed yet");
                }
               
            }
            else
            {
                DisplayStatusOfPrinter(printer);
            }

            Console.Read();
        }
        /// <summary>
        /// Display the status of printer.
        /// </summary>
        /// <param name="printer"></param>
        public static void DisplayStatusOfPrinter(Printer printer)
        {
            switch (printer.PrinterStatus)
            {
                case Status.OutOfPaper:
                    Console.WriteLine("Error infor : " + " Out Of Paper");
                    break;
                case Status.OutOfInk:
                    Console.WriteLine("Error infor : " + " Out Of Ink");
                    break;
                case Status.Disable:
                    Console.WriteLine("Error infor : " + " Disable");
                    break;
                default:
                    break;
            }
        }
    }
}
