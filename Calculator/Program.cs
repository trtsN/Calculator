using System;

namespace Calculator
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите операцию");
            Console.WriteLine("+: сложение");
            Console.WriteLine("-: вычитание");
            Console.WriteLine("*: умножение");
            Console.WriteLine("/: деление");
            Console.WriteLine("%: остаток от деления");
            Console.WriteLine("^: возведение в степень");
            Console.WriteLine("^: возведение в степень");
            Console.WriteLine("!: извлечение из под корня");

            var operand = Console.ReadLine();

            Console.WriteLine("Введите первое число");

            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число");

            double secondNumber = Convert.ToDouble(Console.ReadLine());

            if (operand == "+")
            {
                var result = Add(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (operand == "-")
            {
                var result = Subtract(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (operand == "*")
            {
                var result = Multiply(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (operand == "/")
            {
                var result = Divide(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (operand == "%")
            {
                var result = Modulo(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (operand == "^")
            {
                var result = Exponentiation(firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            else if (operand == "!")
            {
                var result = SquareRoot(firstNumber);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Вы ввели неправильный оператор");
            }
        }

        public static Double Add(double x, double y)
        {
            return x + y;
        }

        public static Double Subtract(double x, double y)
        {
            return x - y;}

        public static Double Multiply(double x, double y)
        {
            return x * y;
        }

        public static Double Divide(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                return 0;
            }

        }

        public static Double Modulo(double x, double y)
        {
            return x % y;
        }

        public static Double Exponentiation(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public static Double SquareRoot(double x)
        {
            if (x < 0)
            {
                return 0;
            }
            else return Math.Sqrt(x);
        }

    }
}
