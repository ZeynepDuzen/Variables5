using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, bolum, ders;
            int s1, s2, s3, ort;
            ad = "Zeynep";
            soyad = "Düzen";
            bolum = "Software";
            ders = "Variables";
            s1 = 100;
            s2 = 90;
            s3 = 85;
            ort = (s1 + s2 + s3) / 3;

            Console.WriteLine("*** Ogrenci not ortalama ***");
            Console.WriteLine();
            Console.WriteLine("Ad : " + ad);
            Console.WriteLine("Soyad : " + soyad);
            Console.WriteLine("Bolum : " + bolum);
            Console.WriteLine("Ders : " + ders);
            Console.WriteLine();
            Console.WriteLine("Sınav 1 : " + s1);
            Console.WriteLine("Sınav 2 : " + s2);
            Console.WriteLine("Sınav 3 : " + s3);
            Console.WriteLine();
            Console.WriteLine("Ortalama : " + ort);
            Console.ReadLine();

        }
    }
}
