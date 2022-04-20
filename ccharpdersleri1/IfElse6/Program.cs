using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 2 sayının seçilen işleme göre
            int sayi1, sayi2;
            char işlem;
            Console.WriteLine("İlk sayıyı giriniz");
            sayi1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz");
            sayi2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Seçilebilecek işlemler: + , - , * , /");
            işlem = Convert.ToChar(Console.ReadLine());
            if (işlem == '+')
                Console.WriteLine("Toplam: " + (sayi2 + sayi1));
            if (işlem == '-')
                Console.WriteLine("Toplam: " + (sayi2 - sayi1));
            if (işlem == '*')
                Console.WriteLine("Toplam: " + (sayi2 * sayi1));
            if (işlem == '/')
                Console.WriteLine("Toplam: " + (sayi2 / sayi1));
            Console.ReadLine();

        }
    }
}
