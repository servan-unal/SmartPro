using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse5
{
    class Program
    {
        static void Main(string[] args)
        {
        //Belirlenen kullanıcı adı ve şifre doğru girildiğinde giriş başarılı yanlış ise şifre hatalı.
        git1:
            string ad = "ahmet";
            string şifre = "admin";
            Console.WriteLine("Adınızı giriniz");
          string  deger1 = Console.ReadLine().ToLower();
            if ((deger1) != ad)
            {
                Console.WriteLine("Lütfen Doğru Adı Giriniz");
                goto git1;
            }
            git2:
            Console.WriteLine("Soydınızı giriniz");
            string deger2 = Console.ReadLine().ToLower();
            
            if (deger2 != şifre)
            {
                Console.WriteLine("Lütfen Doğru Soyadı Giriniz");
                goto git2;
            }
            else
                Console.WriteLine("Giriş Başarılı"); ;

            Console.ReadLine();
        }
    }
}
