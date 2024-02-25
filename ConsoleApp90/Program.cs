using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedenucgenalani
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int taban, yukseklik, alan;

            Console.WriteLine("Lütfen üçgenin tabanını giriniz.");
            taban = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen üçgenin yüksekliğini giriniz.");
            yukseklik = Int32.Parse(Console.ReadLine());

            alan = (taban * yukseklik) / 2;

            Console.WriteLine("Üçgenin alanı={0}", alan);
            Console.ReadLine();


        }
    }
}
