using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class IfElse2
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen sayının çift ya da tek olduğunu bulan program

            //int sayi;
            //Console.WriteLine("bir sayı giriniz");
            //sayi = Int32.Parse(Console.ReadLine());
            //if(sayi%2 ==0)
            //    Console.WriteLine("Sayı çifttir");
            //else
            //    Console.WriteLine("Sayı tektir");

            //Klavyeden girilen vize ve final notunun ortalamasını alacak program
            git:
            Console.WriteLine("Vize notu giriniz");
            double vize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Final notu giriniz");
            double final = Convert.ToDouble(Console.ReadLine());
            double ortalama = (vize * 0.3) + (final * 0.7);
            if (ortalama >= 85 && ortalama <= 100)
                Console.WriteLine("Ortalama: AA ");
            else if (ortalama >= 70 && ortalama < 85)
                Console.WriteLine("Ortalama: BB ");
            else if (ortalama >= 50 && ortalama < 70)
                Console.WriteLine("Ortalama: CC ");
            else
                goto git;
            Console.WriteLine("Ortalama: FF");
                Console.ReadLine();
        }
    }
}
