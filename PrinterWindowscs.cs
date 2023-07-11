using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prak9
{
    public class PrinterWindowscs
    {
        
        public virtual void Show()
        {
            Console.WriteLine("Dimensi display PrinterWindows: 9.5*12");
        }

       
        public virtual void Print()
        {
            Console.WriteLine("PrinterWindows printing...");
        }
    }

    // Class Turunan
    public class Epson : PrinterWindowscs
    {
       
        public override void Show()
        {
            Console.WriteLine("Dimensi dislay Epson: 10*11");
        }

        
        public override void Print()
        {
            Console.WriteLine("Printer Epson printing...");
        }
    }

    // Class Turunan
    public class Canon : PrinterWindowscs
    {
       
        public override void Show()
        {
            Console.WriteLine("Dimensi Display Printer Canon: 9.5*12");
        }

        
        public override void Print()
        {
            Console.WriteLine("Printer Canon printing...");
        }
    }

    // Class Turunan
    public class LaserJet : PrinterWindowscs
    {
       
        public override void Show()
        {
            Console.WriteLine("Dimensi display Printer LaserJet: 12*12");
        }
      
        public override void Print()
        {
            Console.WriteLine("Printer LaserJet printing...");
        }
    }
}
