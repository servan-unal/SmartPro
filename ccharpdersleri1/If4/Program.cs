using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If4
{
    class Program
    {
        static void Main(string[] args)
        {
            // klavyeden girilen alışveriş tutarına göre indirim miktarı uygulayan program.
            double tutar;
            git:
            Console.WriteLine("Tutar Giriniz");
             tutar = Convert.ToDouble(Console.ReadLine());
            double  fiyat1 = tutar * 0.05;
            double fiyat2 = tutar * 0.08;
            double fiyat3 = tutar * 0.085;
            if (tutar < 1000)
                Console.WriteLine("İndirimli Fiyatı: " + (fiyat1 + tutar));
            if (tutar < 10000 && tutar > 1000)
                Console.WriteLine("İndirimli Fiyatı: " + (fiyat2 + tutar));
            if (tutar > 10000 )
                Console.WriteLine("İndirimli Fiyatı: " + (fiyat3 + tutar));
           goto git;
            
        }
    }
}
