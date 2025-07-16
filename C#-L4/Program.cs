using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        //PrintNumbersetween1AndN();
        //PrintMultiplicationTable();
        //PrintEvenNumbersBetween1AndN();
        //CalculateMarks();
        //PrintReverseString();
        //PrintReverseInteger();
        //PrintPrimeNumbersInRange(1,50);
        //ConvertDecimalToBinary(25);
        // checkOfSingleStraight(1, 1, 2, 2, 3, 3);
    }
    /* 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
        Example 
           Input: 5
           Output: 1, 2, 3, 4, 5 */
    private static void PrintNumbersetween1AndN()
    {
        int num = 0;
        do
        {
            Console.WriteLine("Enter your number To Print from 1 to it: ");
            int.TryParse(Console.ReadLine(), out num);

            if (num < 1)
            {
                Console.WriteLine("Please enter a number greater than 0.");
                int.TryParse(Console.ReadLine(), out num);
            }
            else
            {
                Console.WriteLine("The numbers between 1 and " + num + " are:");
                for (int i = 1; i <= num; i++)
                {
                    Console.Write($"{i} -> ");
                }
                Console.WriteLine();
            }
        } while (num < 1);

    }

    /* 2- Write a program that allows the user to insert an integer then 
        print a multiplication table up to 12.
        Example
            Input: 5
            Outputs: 5 10 15 20 25 30 35 40 45 50 55 60 */

    private static void PrintMultiplicationTable()
    {
        const int maxMultiplier = 12;
        int num = 0;
        do
        {
            Console.WriteLine("Enter your number To Print Multiplication Table: ");
            int.TryParse(Console.ReadLine(), out num);

            if (num < 1)
            {
                Console.WriteLine("Please enter a number greater than 0.");
                int.TryParse(Console.ReadLine(), out num);
            }
            else
            {
                Console.WriteLine($"Multiplication table for {num}:");
                for (int i = 1; i <= maxMultiplier; i++)
                {
                    Console.Write($"{num * i} ");
                }
                Console.WriteLine();
            }
        } while (num < 1);
    }

    /* 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
        Example:
            Input: 15
            Output: 2 4 6 8 10 12 14 */

    private static void PrintEvenNumbersBetween1AndN()
    {
        int num = 0;
        do
        {
            Console.WriteLine("Enter your number To Print Even Numbers Between 1 And N: ");
            int.TryParse(Console.ReadLine(), out num);

            if (num < 1)
            {
                Console.WriteLine("Please enter a number greater than 0.");
                int.TryParse(Console.ReadLine(), out num);
            }
            else
            {
                for (int i = 1; i < num; i++)
                {
                    if (i % 2 == 0 && i < num)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
        } while (num < 1);
    }

    /* 4- Write a program that takes two integers then prints the power.
        Example:
            Input: 4 3
            Output: 64
            Hint: how to calculate 4^3 = 4 * 4 * 4 =64 */

    private static void PrintPowerOfTwoIntegers()
    {
        int num = 0;
        do
        {
            Console.WriteLine("Enter your number To Print Power Of Two Integers: ");
            int.TryParse(Console.ReadLine(), out num);

            if (num < 1)
            {
                Console.WriteLine("Please enter a number greater than 0.");
                int.TryParse(Console.ReadLine(), out num);
            }
            else
            {
                Console.WriteLine("Enter the power number: ");
            }
        } while (num < 1);
    }

    /*5- Write a program to enter marks of five subjects and calculate total, average and percentage.
        Example
            Input: - Enter Marks of five subjects: 95 76 58 90 89
            Output: Total marks = 408
            Average Marks = 81
            Percentage = 81*/

    private static void CalculateMarks()
    {
        const int subjects = 5;
        int TotalMarks = 0;
        int AverageMarks = 0;
        int Percentage = 0;
        for (int i = 0; i < subjects; i++)
        {
            Console.WriteLine($"Enter your Marks of subject Number {i + 1}: ");
            int.TryParse(Console.ReadLine(), out int mark);
            TotalMarks += mark;
            AverageMarks = TotalMarks / subjects;
            Percentage = (TotalMarks * 100) / (subjects * 100);
        }
        Console.WriteLine($"Total marks = {TotalMarks}");
        Console.WriteLine($"Average Marks = {AverageMarks}");
        Console.WriteLine($"Percentage = {Percentage}");
    }

    /*6- Write a program to allow the user to enter a string and print the REVERSE of it.*/

    private static void PrintReverseString()
    {
        Console.WriteLine("Enter a string to reverse: ");
        string? inputValue = Console.ReadLine();
        if (inputValue == null) return;
        StringBuilder reversedString = new StringBuilder(inputValue.Length);
        int start = 0;
        int end = inputValue.Length - 1;
        while (start <= end)
        {
            reversedString.Append(inputValue[end]);
            end--;
        }
        Console.WriteLine($"Reversed String: {reversedString}");
    }

    private static void PrintReverseIntegerByInputValeu(string value)
    {
        StringBuilder reversedString = new StringBuilder(value.Length);
        int start = 0;
        int end = value.Length - 1;
        while (start <= end)
        {
            reversedString.Append(value[end]);
            end--;
        }
        Console.WriteLine(reversedString);

    }

    /*7- Write a program to allow the user to enter int and print the REVERSED of it.*/

    private static void PrintReverseInteger()
    {
        Console.WriteLine("Enter an integer to reverse: ");
        string? inputValue = Console.ReadLine();
        if (inputValue == null) return;
        PrintReverseIntegerByInputValeu(inputValue);
    }

    /*8- Write a program in C# Sharp to find prime numbers within a range of numbers.
        Test Data :
        Input starting number of ranges: 1
        Input ending number of range : 50 */

    private static void PrintPrimeNumbersInRange(int start, int end)
    {
        Console.WriteLine($"Prime numbers between {start} and {end} are:");
        for (int num = start; num <= end; num++)
        {
            if (isPrime(num))
            {
                Console.Write(num + " ");
            }
        }
    }
    private static bool isPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    /*9- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
    Test Data :
        Enter a number to convert :25
        Expected Output :
            The Binary of 25 is 11001.*/
    private static void ConvertDecimalToBinary(int num)
    {
        string binary = "";
        while (num > 0)
        {
            int remainder = num % 2;
            binary = remainder + binary;
            num /= 2;
        }

        for (int i = 0; i < binary.Length; i++)
        {
            Console.Write(binary.ElementAt(i));
        }
    }

    /*10- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3),
        and determines whether these points lie on a single straight line.
    How to solve this problem?
    => we used Slope formula => slope = (y2−y1)/(x3−x2) and check if the slope is equal for all three points. 
    => with (y3−y2)(x2−x1) => if (y2−y1)/(x3−x2) = (y3−y2)(x2−x1) is single straight line*/

    private static void checkOfSingleStraight(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        //(y2−y1)/(x3−x2) = (y3−y2)(x2−x1)

        int leftSide = (y2 - y1) * (x3 - x2);
        int rightSide = (y3 - y2) * (x2 - x1);
        if (leftSide == rightSide)
        {
            Console.WriteLine("The points lie on a single straight line.");
        }
        else
        {
            Console.WriteLine("The points do not lie on a single straight line.");
        }
    }

    /*
     11- . Write a program that prints an identity matrix using for loop,
        in other words takes a value n from the user and shows the identity table of size n * n.
     */

    // I don't understand the question well, so I will not implement it.

}
