using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas02
{
    class Soal1
    {
        static void Main(string[] args)
        {
            double A = 10, B = 12, C = 14, luasA, luasB, luasC, arsir;
            const double PHI = 3.14;

            luasA = PHI * (Math.Pow(A, 2));
            luasB = PHI * (Math.Pow(B, 2));
            luasC = PHI * (Math.Pow(C, 2));
            arsir = (luasC - luasB) + luasA;

            Console.WriteLine("================ SOAL 1 =================");
            Console.WriteLine("Luas Lingkaran A = " + luasA + "cm");
            Console.WriteLine("Luas Lingkaran B = " + luasB + "cm");
            Console.WriteLine("Luas Lingkaran C = " + luasC + "cm");
            Console.WriteLine("Jadi luas bagian yang di arsir = " + arsir + "cm");
            Console.WriteLine("=========================================");

            Console.ReadKey();
        }
    class Soal2
        {
            static void Main(string[] args)
            {
            double harga, diskon, hargaDiskon, total;

            harga = 150000;
            diskon = 12.5;
            hargaDiskon = harga * (diskon / 100);
            total = harga - hargaDiskon;

            Console.WriteLine("================ SOAL 2 =================");
            Console.WriteLine("Harga Normal = " + "Rp. " + harga);
            Console.WriteLine("Diskon       = " + "Rp. " + diskon + "%");
            Console.WriteLine("Harga Diskon = " + "Rp. " + hargaDiskon);
            Console.WriteLine("Harga Total  = " + "Rp. " + total);
            Console.WriteLine("=========================================");

            Console.ReadKey();
            }
        }
    }
}