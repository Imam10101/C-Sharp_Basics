using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_practice
{


    class StudentManagementSystem
    {
        // Enum for student statuses
        enum StudentStatus
        {
            Enrolled,
            Graduated,
            OnLeave
        }

        // Structure for student information
        struct StudentInfo
        {
            public string Name;
            public int Age;
            public double GPA;
        }
        // Method to calculate the sum of two numbers
        static int CalculateSum(int x, int y, int z = 0)
        {
            return x + y + z;
        }

        static void Main()
        {
            // 1. Decision and Iteration Statements
            Console.WriteLine("-----------1. Decision and Iteration Statements--------");

            // IF - Else statement
            int studentAge = 20;
            if (studentAge < 18)
            {
                Console.WriteLine("Student is a minor.");
            }
            else
            {
                Console.WriteLine("Student is an adult.");
            }

            // Switch statement
            Console.WriteLine("\nEnter student status (1 for Enrolled, 2 for Graduated, 3 for OnLeave): ");
            int statusInput = int.Parse(Console.ReadLine());
            switch (statusInput)
            {
                case 1:
                    Console.WriteLine("Student is currently enrolled.");
                    break;
                case 2:
                    Console.WriteLine("Student has graduated.");
                    break;
                case 3:
                    Console.WriteLine("Student is on leave.");
                    break;
                default:
                    Console.WriteLine("Invalid input for student status.");
                    break;
            }

            // While loop
            Console.WriteLine("\nUsing while loop to count from 1 to 5:");
            int count = 1;
            while (count <= 5)
            {
                Console.Write(count + " ");
                count++;
            }

            // For loop
            Console.WriteLine("\n\nUsing for loop to print even numbers up to 10:");
            for (int i = 2; i <= 10; i += 2)
            {
                Console.Write(i + " ");
            }

            // For-each loop
            Console.WriteLine("\n\nUsing for-each loop to 1 to 5 through an array:");
            int[] numbersArray = { 1, 2, 3, 4, 5 };
            foreach (var number in numbersArray)
            {
                Console.Write(number + " ");
            }

            // Do-while loop
            Console.WriteLine("\n\nUsing do-while loop to count from 5 to 1:");
            int countdown = 5;
            do
            {
                Console.Write(countdown + " ");
                countdown--;
            } while (countdown >= 1);

            // 2. Declaring, Naming & Assigning Variables
            Console.WriteLine("\n\n------------2. Declaring, Naming & Assigning Variables--------\n");

            // Declare and assign variables using primitive data types
            int studentAgePrimitive = 21;
            double studentGPA = 3.8;
            char studentGrade = 'A';
            bool isStudentActive = true;

            Console.WriteLine($"Student Age: {studentAgePrimitive}, GPA: {studentGPA}, Grade: {studentGrade}, Active: {isStudentActive}");

            // Arithmetic operators
            Console.WriteLine("\nUsing arithmetic operators:");
            int num1 = 10, num2 = 3;
            Console.WriteLine($"Addition: {num1 + num2}");
            Console.WriteLine($"Subtraction: {num1 - num2}");
            Console.WriteLine($"Multiplication: {num1 * num2}");
            Console.WriteLine($"Division: {num1 / num2}");
            Console.WriteLine($"Modulus: {num1 % num2}");

            // Difference between prefix and postfix
            Console.WriteLine("\n---------Difference between prefix and postfix increment operators:  ------------");
            int prefixIncrement = 5;
            int postfixIncrement = 5;

            Console.WriteLine($"Prefix Increment: {++prefixIncrement}"); // Increment before use
            Console.WriteLine($"Postfix Increment: {postfixIncrement++}"); // Use before increment
           

            // 3. Apply Method, Scope, Parameter, Optional Parameter & Named Arguments
            Console.WriteLine("--------3. Apply Method, Scope, Parameter, Optional Parameter & Named Arguments---------------");

            // Method with scope, parameter, optional parameter, and named arguments
            Console.WriteLine("\nUsing a method with parameters, optional parameters, and named arguments:");

            int result1 = CalculateSum(5, 10);//Using Parameter
            Console.WriteLine($"Sum of 5 and 10: {result1}");

            int result2 = CalculateSum(5, 10, 15);// Using optional parameter
            Console.WriteLine($"Sum of 5, 10, and 15: {result2}");

            int result3 = CalculateSum(y: 10, x: 5); // Using named arguments
            Console.WriteLine($"Sum using named arguments: {result3}");

            // 4. Handle Exception using try-catch-finally
            Console.WriteLine("-----------------4. Handle Exception---------------");
            try
            {
                if (studentAge < 18)
                {
                    Console.WriteLine("Student is a minor.");
                }
                else
                {
                    Console.WriteLine("Student is an adult.");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
             
            }

            // 5. Apply enum & structure
            Console.WriteLine(" ------------5. Apply Enum & Structure-----------------");

            // Using enum to represent student status
            StudentStatus currentStatus = StudentStatus.Enrolled;
            Console.WriteLine($"Current student status: {currentStatus}");

            // Using structure to store student information
            StudentInfo student1;
            student1.Name = "Imam Mehedi";
            student1.Age = 22;
            student1.GPA = 3.5;

            Console.WriteLine($"\nStudent Information:\nName: {student1.Name}\nAge: {student1.Age}\nGPA: {student1.GPA}");
        }

      
    }
}
