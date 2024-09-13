using System;

namespace Fraction
{
    public class Fraction
    {
        public int Numerator;
        public int Denominator;
        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        public Fraction(int numerator)
        {
            this.Numerator = numerator;
            this.Denominator = 1;
        }

        public void Print()
        {
            int numberGCD = GCD(Numerator,Denominator);
            if(Numerator% Denominator == 0)
            {
                Console.WriteLine(Numerator/ Denominator);
            }
            else if(Numerator % Denominator != 0)
            {
                Console.WriteLine($"{Numerator/ numberGCD}/{Denominator/ numberGCD}");
            }
            else
            {
                Console.WriteLine($"{Numerator}/{Denominator}");
            }
        }
        public  int GCD (int a, int b)
        {
            while (b!=0)
            {
                int temp = b;
                b = a%b ;
                a = temp;
            }
            return a;
        }
        public Fraction Sum(Fraction othreFraction)
        {
            int commonDenominator = Denominator * othreFraction.Denominator;
            int resultNumorator= Numerator*othreFraction.Denominator + othreFraction.Numerator*Denominator;

            Fraction result = new Fraction(resultNumorator,commonDenominator);

            return result;
        }
        public Fraction Difference(Fraction othreFraction)
        {
            int commonDenominator = Denominator * othreFraction.Denominator;
            int resultNumorator = Numerator * othreFraction.Denominator - othreFraction.Numerator * Denominator;

            Fraction result = new Fraction(resultNumorator, commonDenominator);

            return result;
        }
        public Fraction Multiply(Fraction othreFraction) 
        {
            Fraction result = new Fraction(Numerator * othreFraction.Numerator, Denominator*othreFraction.Denominator);

            return result;
        }
        public Fraction Divide(Fraction othreFraction)
        {
            Fraction result = new Fraction(Numerator * othreFraction.Denominator, Denominator * othreFraction.Numerator);

            return result;
        }

        public Fraction Sum(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);
            Fraction result = Sum(otherFraction);
            return result;  
        }

        public Fraction Difference(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);
            Fraction result = Difference(otherFraction);
            return result;
        }

        public Fraction Multiply(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);
            Fraction result = Multiply(otherFraction);
            return result;
        }

        public Fraction Divide(int number)
        {
            Fraction otherFraction = new Fraction(number, 1);
            Fraction result = Divide(otherFraction);
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числитель первого числа:");
            int numberOneNumerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель первого числа:");
            int numberOneDenominator = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите числитель второго числа:");
            int numberTwoNumerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель второго числа:");
            int numberTwoDenominator = int.Parse(Console.ReadLine());

            Fraction fraction1 = new Fraction(numberOneNumerator, numberOneDenominator);
            fraction1.Print();
            Fraction fraction2 = new Fraction(numberTwoNumerator, numberTwoDenominator);
            fraction2.Print();

            Fraction result = fraction1.Sum(fraction2);
            result.Print();

            result = fraction1.Difference(fraction2);
            result.Print();

            result = fraction1.Multiply(fraction2);
            result.Print();

            result = fraction1.Divide(fraction2);
            result.Print();

            Console.WriteLine("________Result Fraction________");
            result = fraction1.Sum(1);
            result.Print();

            result = fraction1.Difference(1);
            result.Print();

            result = fraction1.Multiply(2);
            result.Print();

            result = fraction1.Divide(2);
            result.Print();
        }
    }
}