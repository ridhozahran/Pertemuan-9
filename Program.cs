using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prak9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrinterWindowscs printer = null;
            Console.WriteLine("Pilih Printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.WriteLine("Nomor Printer[1...3]:");

            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
            {
                printer = new Epson();
            }
            else if (nomorPrinter == 2)
            {
                printer = new Canon();
            }
            else if (nomorPrinter == 3)
            {
                printer = new LaserJet();
            }
            else
            {
                Console.WriteLine("Anda salah memasukkan pilihan\n");
            }

            if (printer != null)
            {
                printer.Show();
                printer.Print();
            }

            Console.ReadKey();
        }
    }

}

