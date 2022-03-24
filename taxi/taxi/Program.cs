using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
     class Program
    {
        static void Main(string[] args)
        {
            // Membuat Objek taxi
            Taxi taxi = new Taxi();

            // pengesetan nilai properties
            taxi.DriverName = "Jono";
            taxi.onDuty = true;
            taxi.NumPassenger = 10;

            // pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
