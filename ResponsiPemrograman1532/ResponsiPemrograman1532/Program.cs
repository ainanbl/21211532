using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman1532
{
        class Program
        {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan(190302123, "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan(190302124, "Jono", 2000000);


            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.WriteLine("\n\nAsikkkkk dpt kenaikan gaji 10%!!\n");

            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t | Gaji Bulanan\t |");
            Console.WriteLine("==================================================");
            Console.WriteLine(" 1. | {0} {1} \t\t | {2}\t |", karyawan1.NIK, karyawan1.Nama, karyawan1.NaikGaji);
            Console.WriteLine(" 2. | {0} {1} \t\t | {2}\t |", karyawan2.NIK, karyawan2.Nama, karyawan2.NaikGaji);


            Console.ReadKey();
        }
    }
}
