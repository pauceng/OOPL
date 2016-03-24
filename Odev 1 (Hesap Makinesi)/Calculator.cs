using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Calculator
{
    class Calculator
    {
        //İki sayının toplamını bulan method
        public double Topla(double birinciSayi ,double ikinciSayi)
        {
            return  birinciSayi + ikinciSayi;
        }
        //İki sayınnın farkını bulan method
        public double Fark(double birinciSayi, double ikinciSayi)
        {
            return birinciSayi - ikinciSayi;
        }
        //iki sayının çarpımını bulan method
        public double Carpim(double birinciSayi, double ikinciSayi)
        {
            return birinciSayi * ikinciSayi;
        }
        //İki sayının bölümünü bulan method
        public double Bolum(double birinciSayi, double ikinciSayi)
        {
            if (ikinciSayi == 0)
            {
                Console.WriteLine("Sayi 0'ra Bölünemez...!");
                Control.Menu();
            }
            return birinciSayi / ikinciSayi;
        }
    }
}
