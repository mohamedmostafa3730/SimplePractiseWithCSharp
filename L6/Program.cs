/* 1- Explain the difference between passing (Value type parameters)
        by value and by reference then write a suitable c# example.*/

int getSumByValue(int x, int y)
{
    x++; y++;
    return x + y;
}

int getSumByReference(ref int x, ref int y)
{
    x++; y++;
    return x + y;
}

int num1 = 10, num2 = 20;
int num11 = 30, num22 = 40;

//Console.WriteLine($"num1 = {{{num1}}}, num2 = {{{num2}}}");
//Console.WriteLine(getSumByValue(num1,num2));
//Console.WriteLine($"num1 = {{{num1}}}, num2 = {{{num2}}}");
//Console.WriteLine($"num11 = {{{num1}}}, num2 = {{{num22}}}");
//Console.WriteLine(getSumByReference(ref num11, ref num22));
//Console.WriteLine($"num11 = {{{num11}}}, num2 = {{{num22}}}");

/* 2- Explain the difference between passing (Reference type parameters)
     by value and by reference then write a suitable c# example.*/

int[] arr1 = { 32,47,567,56,8456,8,4567,3,5 };

int[] MDOAllElementsInArrayByValue(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] /= 2;
    }
    return nums;
}
int[] MDOAllElementsInArrayByReference(ref int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] /= 2;
    }
    return nums;
}
void print(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{{{item}}}");
    }
    Console.WriteLine();
}
//print(arr1);
//MDOAllElementsInArrayByValue(arr1);
//print(arr1);
//MDOAllElementsInArrayByReference(ref arr1);
//print(arr1);

/* 3- Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers */

void getSumAndSubtraction(int x, int y, out int sum, out int sub)
{
    sum = x + y;
    sub = x - y;
}

(int,int) getSumAndSubtractionTuple(int x, int y)
{
    return (x + y, x - y);
}

int a = 10, b = 5;
int aout,bout;
getSumAndSubtraction(a, b, out aout, out bout);
//Console.WriteLine($"SUM = {{{aout}}}, SUB = {{{bout}}}");
//Console.WriteLine(getSumAndSubtractionTuple(a,b)) ;

/* 1- Write a program in C# Sharp to create a function to calculate the sum of
   the individual digits of a given number.
        Output should be like 
        Enter a number: 25                                                                                            
        The sum of the digits of the number 25 is: 7 */

int getSumOfDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10; // Get the last digit and add it to sum
        num /= 10;       // Remove the last digit
    }
    return sum;
}

//Console.Write(getSumOfDigits(668));

/* 5- Create a function named "IsPrime", which receives an integer number and returns true if it is prime,
    or false if it is not: */

bool IsPrime(int num)
{
    if (num <= 1) return false;
    for (int i = 2; i <= num/2; i++)
    {
        if (num % i == 0) return false; 
    }
    return true; 
}
//Console.WriteLine(IsPrime(7)); 
//Console.WriteLine(IsPrime(10)); 
//Console.WriteLine(IsPrime(1));

/* 6- Create a function named MinMaxArray, to return the minimum and maximum values stored in an array,
    using reference parameters */

void MinMaxArray(int[] arr, ref int min, ref int max)
{
    foreach (var item in arr)
    {
        if (item < max)
        {
            max = item;
        }
        else if (item > min)
        {
            min = item;
        }
    }
}

arr1 = new int[] { 32, 47, 5,67, 56, 84,56, 8, 45,67, 3, 5 };
int min = int.MinValue, max = int.MaxValue;
MinMaxArray(arr1, ref min, ref max);
//Console.WriteLine($"Min = {{{min}}}, Max = {{{max}}}");

/* 7- Create an iterative (non-recursive) function
    to calculate the factorial of the number specified as parameter */

long Factorial(int num)
{
    long result = 1;
    for (int i = 1; i <= num; i++)
    {
        result *= i;
    }
    return result; 
}

//Console.WriteLine(Factorial(3));

/* 8-	Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string,
    replacing it with a different letter */
string ChangeChar(string str, int position, char newChar)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (i == position)
        {
            str = str.Remove(position,1).Insert(position,newChar.ToString());
            break;
        }
    }
    return str;
}
//Console.WriteLine(ChangeChar("Hello World", 5, '_'));