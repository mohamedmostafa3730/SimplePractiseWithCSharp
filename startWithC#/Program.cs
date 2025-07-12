using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        //GetNuberToPrintIt();                      // => 1
        //ConvertStringToInt();                     // => 2
        //arithmeticOperationWithfloatingPoint();   // => 3
        //ExtractSubstring();                       // => 4
        //AssigningValueType();                     // => 5
        //AssigningReferenceType();                 // => 6
        //ConcatenateStrings("Mohamed", "Ahmed");   // => 7
        //calculatesSimpleInterest(1000, 5, 2);     // => 8
        //calculatesBodyMassIndex(75, 168);         // => 9
        //CheckTemperature(35);                     // => 10
        //dateFormats(1,6,2001);                    // => 11
        //checkCanDividedBy3And4(12);               // => 12
        //checkNegativeOrPositive(-1);              // => 13
        //GetMaxAndMinNum1(3,5,6);                  // => 14
        //GetMaxAndMinNum2(3, 5, 6);                // => 14
        //IsNumOddOrEven(3);                        // => 15
        //CheckIfvowelOrConsonant('s');             // => 16
        //MonthDays(2);                             // => 17
    }

    //1. Write a program that allows the user to enter a number then print it.
    public static void GetNuberToPrintIt()
    {
        Console.WriteLine("Enter the number to Print it");
        int.TryParse(Console.ReadLine(), out int num);
        Console.WriteLine($"The number you entered is: {num}");
    }


    //2. Write program converts a string to an integer, but the string contains non-numeric characters
    //   And mention what will happen

    public static void ConvertStringToInt()
    {
        Console.WriteLine("Enter a string to convert it to an integer:");
        string? word = Console.ReadLine();
        int.TryParse(word, out int num);
        if (num == 0 && !string.IsNullOrEmpty(word) && !word.Equals("0"))
        {
            Console.WriteLine("The string contains non-numeric characters, conversion failed.");
        }
        else
        {
            Console.WriteLine($"The converted integer is: {num}");
        }
        // This demonstrates that if the string contains non-numeric characters,
    }

    //3. Write C# program that Perform a simple arithmetic operation with floating-point numbers
    //   And mention what will happen

    public static void arithmeticOperationWithfloatingPoint()
    {
        Console.WriteLine("Enter first number:");
        float.TryParse(Console.ReadLine(), out float num1);
        Console.WriteLine("Enter second number:");
        float.TryParse(Console.ReadLine(), out float num2);
        float result = num1 + num2;
        Console.Clear();
        Console.WriteLine("====================================================");
        Console.WriteLine($"The result of adding {num1} and {num2} is: {result}");
        // This demonstrates that floating-point numbers can represent decimal values,
    }

    //4. Write C# program that Extract a substring from a given string.

    public static void ExtractSubstring()
    {
        Console.WriteLine("Enter The String:");
        string? Word = Console.ReadLine();
        Console.WriteLine("starting index:");
        int startIndex = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("length of the substring:");
        int length = int.Parse(Console.ReadLine() ?? "0");
        if (Word != null && startIndex >= 0 && length > 0 && startIndex + length <= Word.Length)
        {
            string substring = Word.Substring(startIndex, length);
            Console.WriteLine($"The extracted substring is: {substring}");
        }
        else
        {
            Console.WriteLine("Invalid input for substring extraction.");
        }
    }

    //5. Write C# program that Assigning one value type variable
    //   to another and modifying the value of one variable and mention what will happen

    public static void AssigningValueType()
    {
        int a = 10;
        int b = a;
        b += 5;
        Console.WriteLine($"a: {a}, b: {b}"); // Output will be a: 10, b: 15
        // This demonstrates that value types are copied by value, not by reference.
    }

    // 6. Write C# program that Assigning one reference type variable to another anda
    //    modifying the object through one variable and mention what will happen

    public class Person
    {
        string name;

        public Person(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
    }

    public static void AssigningReferenceType()
    {
        Person p1 = new Person("moahmed");
        Person p2 = new Person("Ahmed");
        Console.WriteLine($"Name of first person is: {p1.GetName()} \nName of second person is: {p2.GetName()}");
        Console.WriteLine("======= After modifying ====");
        p1 = p2;
        Console.WriteLine($"Name of first person is: {p1.GetName()} \nName of second person is: {p2.GetName()}");
        // This demonstrates that reference types are copied by reference, so both variables point to the same object.
    }

    //7. Write C# program that take two string variables and print them as one variable

    public static void ConcatenateStrings(string Fname, string Lname)
    {
        Console.WriteLine($"Your Full Name: {Fname} {Lname}");
    }

    // 8. Write a program that calculates the simple interest given the principal amount, rate of interest, and time.
    //    Note : The formula for simple interest is Interest = (principal* rate * time ) /100.
        
        public static void calculatesSimpleInterest(double principal, double rate, double timeYears)
        {
        double Interest = (principal * rate * timeYears) / 100;
        Console.WriteLine($"the Interest = {principal} * {rate} * {timeYears} / 100 = {Interest}");
        }

    // 9. Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
    //    Note :The formula for BMI is BMI = (Weight)/(Height* Height)
        
        public static void calculatesBodyMassIndex(double weight, double height)
        {
            double BMI = weight / (height * height);
            Console.WriteLine($"The BMI is: {BMI}");
        }

    /* 10.	Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. 
        Note : 
            a.that below 10 degrees is "Just Cold"
            b.above 30 degrees is "Just Hot"
            c.anything else is "Just Good"
    */

    public static void CheckTemperature(int temperature)
    {
        string result;

        if (temperature < 10)
        {
            result = "Just Cold";
        }
        else if(temperature > 30)
        {
            result = "Just Hot";
        }
        else
        {
            result = "Just Good";
        }
        Console.WriteLine($"The temperature is: {result}");
    }

    /* 11.Write a program that takes the date from the user and displays it in various formats using string interpolation.
    Ex :
        Today’s date : 20 , 11 , 2001
        Today's date : 20 / 11 / 2001
        Today's date : 20 – 11 – 2001
    */

    public static void dateFormats(int day, int month, int year)
    {
        Console.WriteLine($"Today’s date : {day} , {month} , {year}");
        Console.WriteLine("========================================");
        Console.WriteLine($"Today’s date : {day} / {month} / {year}");
        Console.WriteLine("========================================");
        Console.WriteLine($"Today’s date : {day} – {month} – {year}");
    }

    /* 12- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
        Example (1)
            Input: 12 
            Output: Yes
            Example (2)
            Input: 9 
            Output: No
     */

    public static void checkCanDividedBy3And4(int num)
    {
        if (num % 3 == 0 && num % 4 == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    /* 13- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
        Example (1)
            Input: -5
            Output: negative
        Example (2)
            Input: 10
            Output: positive
     */

    public static void checkNegativeOrPositive(int num)
    {
        if (num < 0)
        {
            Console.WriteLine("negative");
        }
        else
        {
            Console.WriteLine("positive");
        }
    }


    /* 14- Write a program that takes 3 integers from the user then prints the max element and the min element.
        Example (1)
            Input:7,8,5
           Output:
            max element = 8
            min element = 5
    —------------------
        Example (2)
            Input: 3 6 9
           Outputs:
            Max element = 9
            Min element = 3
     */

    public static void GetMaxAndMinNum1(int num1, int num2, int num3)
    {
        Console.WriteLine($"max element = {Math.Min(num1,Math.Min(num2,num3))} \nmin element = {Math.Max(num1, Math.Max(num2, num3))}");
    }

    public static void GetMaxAndMinNum2(int num1, int num2, int num3)
    {
        int max = num1;
        int min = num1;

        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }

        if (num2 < min)
        {
            min = num2;
        }

        if (num3 < min)
        {
            min = num3;
        }
        Console.WriteLine("Max element: " + max);
        Console.WriteLine("Min element: " + min);

    }

    /* 15- Write a program that allows the user to insert an integer number then check If a number is even or odd. */

    public static void IsNumOddOrEven(int num)
    {
        if (num%2!=0)
        {
            Console.WriteLine($"{num} is ODD");
        }
        else
        {
            Console.WriteLine($"{num} is EVEN");
        }
    }

    /* 16- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
        Example (1)
            Input: O
            Output: vowel
        Example (2)
            Input: b
            Output: Consonant 
    */

    public static void CheckIfvowelOrConsonant(Char character)
    {
        if (character == 'a'|| character == 'A' || character == 'e' || character == 'E' || character == 'I' || character == 'i' || character == 'o' || character == 'O' || character == 'u' || character == 'U')
        {
            Console.WriteLine($"{character} is vowel");
        }
        else
        {
            Console.WriteLine($"{character} is Consonant");
        }
    }

    /* 17- Write a program to input the month number and print the number of days in that month.
        Example
            Input: Month Number: 1
            Output: Days in Month: 31
    */

    public static void MonthDays(int MonthNumber)
    {
        if (MonthNumber == 1 || MonthNumber == 3 || MonthNumber == 5 || MonthNumber == 7 ||
            MonthNumber == 8 || MonthNumber == 10 || MonthNumber == 12)
        {
            Console.WriteLine("This month has 31 days.");
        }
        else if (MonthNumber == 4 || MonthNumber == 6 || MonthNumber == 9 || MonthNumber == 11)
        {
            Console.WriteLine("This month has 30 days.");
        }
        else if (MonthNumber == 2)
        {
            Console.WriteLine("This month has 28 days.");
        }
        else
        {
            Console.WriteLine("Invalid month number.");
        }
    }
}