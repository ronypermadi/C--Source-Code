using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1{
    class Program{
        static void Main(string[] args){
            int alas;
            int tinggi;
            double luas;

            Console.WriteLine("\n==============================");
            Console.WriteLine("----------HITUNG LUAS SEGITIGA----------");
            Console.WriteLine("==============================\n");
            Console.Write("Input Alas\t: ");
            alas = Int16.Parse(Console.ReadLine());
            Console.Write("Input Tinggi\t: ");
            tinggi = Int16.Parse(Console.ReadLine());
            luas = (alas * tinggi) / 2;
            Console.WriteLine("\n==============================\n");

            Console.WriteLine("\n==============================");
            Console.WriteLine("----------HASIL PERHITUNGAN DATA--------");
            Console.WriteLine("==============================\n");
            Console.WriteLine("Alas\t: " + alas);
            Console.WriteLine("Tinggi\t: " + tinggi);
            Console.WriteLine("Luas\t: " + luas);
            Console.WriteLine("\n==============================\n");
            Console.ReadLine();
        }
    }
}
