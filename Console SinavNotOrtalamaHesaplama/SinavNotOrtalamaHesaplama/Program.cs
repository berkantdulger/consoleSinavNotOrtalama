using System;

namespace SinavNotOrtalamaHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int yazili1;
            int yazili2;
            int yazili3;
            int ort;

            Console.WriteLine("1. yazılı puanını giriniz");
            yazili1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. yazılı puanını giriniz");
            yazili2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3. yazılı puanını giriniz");
            yazili3 = Convert.ToInt32(Console.ReadLine());

            ort = (yazili1 + yazili2 + yazili3) / 3;
            Console.WriteLine("sınav ortalamanız= " + ort);
            Console.ReadLine();
        }
    }
}
