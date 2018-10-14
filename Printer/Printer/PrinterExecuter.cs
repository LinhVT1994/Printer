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
            Console.WriteLine(printer.GetStatus());
            Console.WriteLine("Print the first time: ");
            sucess = printer.Print();
            if (sucess)
            {
                Console.WriteLine("Status of this printer after printing at first:");
                Console.WriteLine(printer.GetStatus());
            }
            else
            {
                Console.WriteLine("Something false.");
            }


            Console.WriteLine("Print the second time: ");

            sucess = printer.Print();
            if (sucess)
            {
                Console.WriteLine("Status of this printer after printing at second:");
                Console.WriteLine(printer.GetStatus());
            }
            else
            {
                Console.WriteLine("Something false.");
            }
            Console.Read();
        }
    }
}
