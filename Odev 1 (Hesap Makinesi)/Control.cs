using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Calculator
{
    class Control
    {
        //Klavyeden okunan verinin sayi olup olmadığını kontrol eden method
        public static bool IsNumber(string input)
        {
            int  outTemp;
            bool controlNumber = int.TryParse(input, out outTemp);
            if (controlNumber)
                return true;
            else
                return false;
        }
        //Klavyeden okunan verinin eksi sayi olup olmadığını kontrol eden method
        public static bool IsMinuceNumber(string input)
        {
            if (!input.Contains("")) //Entere bastığında 
            {
                if (IsPointNumber(input.Substring(1)) == true || IsNumber(input.Substring(1)) == true && input[0] == 45)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        //Sayinın ondalıklı olma durumunu
        public static bool IsPointNumber(string input)
        {
            int countPoint = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == 44) // , karakterinin ascii karşılığı ile kontrolü
                    if (IsNumber(input.Substring(0,i)) == true && IsNumber(input.Substring(i+1)) == true)//
                        countPoint++;
            }
            if (countPoint == 1 && input[0] != 44)
                return true;
            else
                return false;
        }
        //İşlem zamanı işlem karakterlerinin doğruluğunu ascii değerlerine göre kontrol eden method
        public static bool IsOperation(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[0] == 47 || input[0] == 43 || input[0] == 45 || input[0] == 42)
                    return true;
            }
            return false;
        }
        //control sınıfından erişilen ve E,e ve h,H karekterlerinin doğruluğunu kontrol eder
        static bool yesNo(string input)
        {
            int countTrue = 0, countFalse = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[0] == 101 || input[0] == 69 || input[0] == 104 || input[0] == 72)
                    return true;
            }
            return false;
        }
        //Menu methodu, Kullanıcinin devam etme isteyine göre evet hayır durumunu sorgular
        public static void Menu()
        {
            string islem;
            Console.Write("Devam etmek istiyor musunuz?(e/h):");
            islem = Console.ReadLine();
            while (yesNo(islem) == false)
            {
                Console.Write("\tHatalı Seçim...!\nDevam etmek istiyor musunuz?(e/h):");
                islem = Console.ReadLine();
            }
            if (islem.Substring(0) == "e" || islem.Substring(0) == "E")
            {
                Console.Clear();
                Test.Main();
            }
            else if (islem.Contains("h") || islem.Contains("H"))
            {
                Console.WriteLine("\n\t\t\t\tKolay Gelsin Hocam... :)");
                Environment.Exit(1);
                
            }
        }
    }
}
