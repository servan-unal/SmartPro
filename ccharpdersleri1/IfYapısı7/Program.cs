using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfYapısı7
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            char işlem;
            Console.WriteLine("Lütfen Adınızı giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("Hoşgeldiniz Sayın {0} Bey", ad);
            Console.WriteLine("Bakiyeniz:  {0} TL" , bakiye);
            baş:
            Console.WriteLine("Para Yatırmak için 1'e, para çekmek için 2'ye, bakiyenizi öğrenmek için 3'e basabilirsiniz.");
            işlem = Convert.ToChar(Console.ReadLine());
            if (işlem == '1')
            {
                Console.WriteLine("Eklenecek tutarı giriniz");
                int tutar = Convert.ToInt32(Console.ReadLine());
                bakiye = bakiye + tutar;
                Console.WriteLine("Bakiyeniz: {0}",bakiye);
            }
            if (işlem == '2')
            {
                git:
                Console.WriteLine("Çekilecek tutarı giriniz");
                int tutar2 = Convert.ToInt32(Console.ReadLine());
                if(tutar2 >bakiye) { 
                    Console.WriteLine("O kadar paran yok.");
                    goto git;
                }
                bakiye = bakiye - tutar2;
                Console.WriteLine("Bakiyeniz: {0}", bakiye);
            }
            if (işlem == '3')
                Console.WriteLine("Bakiyeniz: {0}", bakiye);
            
            Console.WriteLine("Başka işlem yapmak istiyor musunuz? evet ya da hayır");
            string cevap = Console.ReadLine();
            if (cevap == "evet")
                goto baş;
            else
                Environment.Exit(0);
            Console.ReadLine();
        }
    }
}
