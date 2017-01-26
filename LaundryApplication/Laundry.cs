using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryApplication
{
    class Laundry
    {
        public bool IsOn { get; set; }
        public string Program { get; set; }
        public double Temperature { get; set; }
        public int Runtime { get; set; }
        public int Spinrpm { get; set; }
        public double Waterusage { get; set; }

        public void Wash()
        {
            Console.WriteLine("Washing cycle will commence. Current program: " + Program + "\nClear the immediate area at the risk of bone liquifycation. ");
            Console.WriteLine("Temperature : " + Temperature);
            Console.WriteLine("Spinning rpm : " + Spinrpm);
            Console.WriteLine("Water usage : " + Waterusage);
            Console.WriteLine("Runtime : " + Runtime);
        }
    }
}
