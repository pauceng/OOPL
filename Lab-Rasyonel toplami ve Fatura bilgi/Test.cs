using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01Aprel
{
    class Test
    { 
        static void Main(string[] args)
        {
            //Invoice invoce1 = new Invoice("A1","Kalem",5,3);
            //invoce1.Quantity = -4; //Koşulu sağlamasa önceki rakamı saklıyor
            //Console.WriteLine(invoce1.InvoiceDisplay());
            //Console.WriteLine(invoce1.GetInvoiceAmount());
            Rational r1 = new Rational(100,60);
            Rational r2 = new Rational(40, 30);
            Rational r3 = r1.sum(r2);
            Console.WriteLine("Toplam:");
            Console.WriteLine(r3);
        }
    }
}
