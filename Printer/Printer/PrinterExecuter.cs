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

            Console.WriteLine("Status of this printer before printing:");
            Console.WriteLine(printer.GetInfo());
           

            if (printer.PrinterStatus == Status.Available)
            {
                Console.WriteLine("This printer is ready for printing:");
                printer.Print();
                Console.WriteLine("Status of this printer after printing at first:");
                Console.WriteLine(printer.GetInfo());
            }
            else
            {
                if (printer.PrinterStatus == Status.OutOfInk)
                {
                    Console.WriteLine("Error infor : "+" Out Of Ink");
                }
                else if (true)
                {
                    Console.WriteLine("Error infor : " + " Out Of Ink");
                }

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

            Console.WriteLine("Print the second time: ");

            sucess = printer.Print();
            if (sucess)
            {
                Console.WriteLine("Status of this printer after printing at second:");
                Console.WriteLine(printer.GetInfo());
            }
            else
            {
                Console.WriteLine("Something false.");
            }
            Console.Read();
        }
    }
}
