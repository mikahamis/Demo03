using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaundryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Laundry laundry = new Laundry();
            laundry.IsOn = true;
            laundry.Program = "Cotton";
            laundry.Temperature = 90.0;
            laundry.Runtime = 135;
            laundry.Spinrpm = 1200;
            laundry.Waterusage = 15;

            laundry.Wash();
        }
    }
}
