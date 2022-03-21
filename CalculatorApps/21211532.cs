using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            // int a = 10;
            // int b = 6;
            Console.WriteLine();
            Console.WriteLine("Pilih menu calculator :");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("Input pilihan = ");
            int menu = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (menu == 1)
            {
                Console.WriteLine("Hasil Penambahan " + a + "+" + b + "=" + Penambahan(a, b));
            }
            else if (menu == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
            }
            else if (menu == 3)
            {
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (menu == 4)
            {
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.WriteLine("Maaf menu yang anda pilih tidak tersedia");
            }

            // Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            // Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            // Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            // Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}