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
                Console.WriteLine("Status of this printer before printing:");
            }
            else
            {

            }
            sucess = printer.Print();

            printer.Print();
            Console.WriteLine(printer.GetStatus());

            Console.WriteLine(printer.Print());
            Console.Read();
        }
    }
}
