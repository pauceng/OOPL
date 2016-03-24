using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Calculator
{
    class Test
    {
        public static void Main()
        {
            Console.Title = "Hesap Makinesi";
            Console.WriteLine("\tÖğrenci Hesap Makinesine Hoş Geldiniz.\n-Örnekte belirtilen sayı tipleri formatında işlem yapmaktadır.Örnek:{ 4 ; -4; 4,4 ; -4,4 }.\n-Ondalıklı sayılar için ',' karekteri desteklemektedir.Teşekkürler...!\n\n");
            string sayiA, sayiB, islem;
            Console.Write("Birinci sayiyi giriniz :");
            sayiA = Console.ReadLine();
            //Birinci sayının hatalı durumu
            if (sayiA != null)
            {
                while (Control.IsNumber(sayiA) == false && Control.IsMinuceNumber(sayiA) == false && Control.IsPointNumber(sayiA) == false)
                {
                    Console.Write("\tGecersiz bir sayı girdiniz...!\nBirinci sayiyi giriniz :");
                    sayiA = Console.ReadLine();
                }
            }

            Console.Write("Islemi giriniz(+,-,*,/):");
            islem = Console.ReadLine();
            //İşlem karekterinin hatalı durumu
            while (Control.IsOperation(islem) == false)
            {
                Console.Write("\tGecersiz işlem...!\nIslemi giriniz(+,-,*,/):");
                islem = Console.ReadLine();
            }
            Console.Write("İkinci  sayiyi giriniz :");
            sayiB = Console.ReadLine();
            //İkinci sayının hatalı durumu
            while (Control.IsNumber(sayiB) == false && Control.IsMinuceNumber(sayiB) == false && Control.IsPointNumber(sayiB) == false)
            {
                Console.Write("\tGecersiz bir sayı girdiniz...!\nİkinci sayiyi giriniz :");
                sayiB = Console.ReadLine();
            }
            if (islem.Contains("+"))
            {
                Console.WriteLine("\n\tSonuc: " + sayiA + " + " + sayiB + " = " + new Calculator().Topla(double.Parse(sayiA), double.Parse(sayiB)));
                Control.Menu();
            }
            else if (islem.Contains("-"))
            {
                Console.WriteLine("\n\tSonuc: " + sayiA + " - " + sayiB + " = " + new Calculator().Fark(double.Parse(sayiA), double.Parse(sayiB)));
                Control.Menu();
            }
            else if (islem.Contains("*"))
            {
                Console.WriteLine("\n\tSonuc: " + sayiA + " * " + sayiB + " = " + new Calculator().Carpim(double.Parse(sayiA), double.Parse(sayiB)));
                Control.Menu();
            }
            else if (islem.Contains("/"))
            {
                Console.WriteLine("\n\tSonuc: " + sayiA + " / " + sayiB + " = " + new Calculator().Bolum(double.Parse(sayiA), double.Parse(sayiB)));
                Control.Menu();
            }
        }
   
    }
}
