using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01Aprel
{
    class Rational
    {
        int numerator, denominator;
        public int Numerator
        {
            get
            {
                return numerator;
            }

            set
            {
                numerator = value;
            }
        }
        public int Denominator
        {
            get
            {
                return denominator;
            }

            set
            {
                if (value >= 0)
                    denominator = value;
            }
        }
        public Rational() { }
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        //Ebob bulan method
        private int GreatestCommonDivisor()
        {
            int temp, greater = numerator, smaller = denominator;
            if (numerator > denominator)
            {
                greater = numerator; smaller = denominator;
            }
            else
            {
                greater = denominator; smaller = numerator;
            }
            while (smaller != 0)
            {
                temp = greater;
                greater = smaller;
                smaller = temp % smaller;
            }
            return greater;
        }
        //rasyonel sayı sadeleştirme
        private void Reduce()
        {
            int gcd = GreatestCommonDivisor();
            numerator = numerator / gcd;
            denominator = denominator / gcd;
        }

        public string Display()
        {
            Reduce();
            return numerator + "\n--\n" + denominator;
        }
        //iki rasiyonel sayı toplayan method
        public Rational sum(Rational r)
        {
            return new Rational(numerator * r.Denominator + denominator * r.numerator, denominator * r.Denominator);
        }
        public override string ToString()
        {
            return Display();
        }
    }
}
