using System;

namespace LuasSegitiga
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Program Menghitung luas persegi panjang
            double totalSegitiga, alas, tinggi, result;
        
            Console.WriteLine("\t*** Menghitung Luas Segitiga Menggunakan C# ***");
            
            Console.Write("\tMasukkan total segitiga yang ingin di hitung luasnya : ");
            totalSegitiga = double.Parse(Console.ReadLine());

            for (var i = 1; i <= totalSegitiga; i++)
            {
                Console.Write("\tMasukkan alas segitiga ke-{0} (cm) : ", i);
                alas = double.Parse(Console.ReadLine());
        
                Console.Write("\tMasukkan tinggi segitiga ke-{0} (cm) : ", i);
                tinggi = double.Parse(Console.ReadLine());
        
                result = 0.5 * alas * tinggi;
                Console.WriteLine("\n\tLuasnya adalah : {0} cm", result);   
            }
        }
    }
}