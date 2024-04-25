using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidenceHW3
{
    public delegate double ArithmeticOperation(double num1, double num2);

   public  class Calculator
    {
     
        public static double Add(double num1, double num2) { return num1 + num2; }
        public static double Subtract(double num1, double num2) { return num1 - num2; }
        public static double Multiply(double num1, double num2) { return num1 * num2; }

      
        public static double Divide(double num1, double num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return double.NaN;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOperation addDelegate = Calculator.Add;
            ArithmeticOperation subtractDelegate = Calculator.Subtract;
            ArithmeticOperation multiplyDelegate = Calculator.Multiply;
            ArithmeticOperation divideDelegate = Calculator.Divide;

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"\nAddition: {addDelegate(num1, num2)}");
            Console.WriteLine($"Subtraction: {subtractDelegate(num1, num2)}");
            Console.WriteLine($"Multiplication: {multiplyDelegate(num1, num2)}");
            Console.WriteLine($"Division: {divideDelegate(num1, num2)}");

            Console.ReadKey();
        }
    }
}
