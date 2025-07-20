using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        //evaluatetdWorkWithIf(2);
        //PrintIdentityMatrix(3);
        int[] num1 = { 2,4,1,6,8,2 };
        //int[] num2 = { 9,5,7,5,2,0 };
        //getSumElements(nusm);
        //mergeTwoArrays(num2,num1);
        //getFreq(num1);
        getMaxAndMin(num1);




    }
    /* 1- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.
        A worker's efficiency level is determined as follows: 
        - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
        - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
        - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
        - If the worker takes more than 5 hours, they are required to leave the company. 
    To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.*/

    public static void evaluatetdWorkWithIf(int time)
    {
        if (time == 2||time==3)
        {
            Console.WriteLine("The worker is highly efficient.");
        }
        else if (time == 3|| time == 4)
        {
            Console.WriteLine("The worker is instructed to increase their speed.");
        }
        else if (time == 4 || time == 5)
        {
            Console.WriteLine("The worker is provided with training to enhance their speed.");
        }
        else if (time > 5)
        {
            Console.WriteLine("The worker is required to leave the company");
        }
        else
        {
            Console.WriteLine("Not Valid Number.");
        }
    }

    public static void evaluatetdWorkWithSwitch(int time)
    {
        switch (time)
        {
            case 2:
            case 3:
                Console.WriteLine("The worker is highly efficient.");
                break;
            case 4:
                Console.WriteLine("The worker is instructed to increase their speed.");
                break;
            case 5:
                Console.WriteLine("The worker is provided with training to enhance their speed.");
                break;
            default:
                if (time > 5)
                {
                    Console.WriteLine("The worker is required to leave the company");
                }
                else
                {
                    Console.WriteLine("Not Valid Number.");
                }
                break;
        }
    }

    /*
     2- . Write a program that prints an identity matrix using for loop,
    in other words takes a value n from the user and shows the identity table of size n * n.
     */
    public static void PrintIdentityMatrix(int n)
    {
        for (int row = 0 ; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (row == col)
                    Console.Write(" 1 ");
                else
                    Console.Write(" 0 ");
            }
            Console.WriteLine();
        }
    }


    /*3- Write a program in C# Sharp to find the sum of all elements of the array.*/

    public static void getSumElements(int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        Console.WriteLine($"The sum of nums in Arrays is => {sum} ");
    }

    /* 4- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order. */

    public static void mergeTwoArrays(int[] arr1, int[] arr2)
    {
        int fullSize = arr1.Length + arr2.Length;
        int[] nums = new int[fullSize];
        int i = 0;
        int j = 0;
        int k = 0;
        Array.Sort(arr1);
        Array.Sort(arr2); 
        while (i < arr1.Length && j < arr2.Length) // i = arr1 | j = arr2 | k = nums
        {
            if (arr1[i] <= arr2[j])
            {
                nums[k] = arr1[i];
                k++;
                i++;
            }
            else
            {
                nums[k] = arr2[j];
                k++;
                j++;
            }

        }

        while (i < arr1.Length)
        {
            nums[k] = arr1[i];
            k++;
            i++;
        }

        while (j < arr2.Length)
        {
            nums[k] = arr2[j];
            j++;
            k++;
        }

        for (i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }


        //Array.Sort(arr1);
        //Array.Sort(arr2);


    } // O(n log n)

    /*5- Write a program in C# Sharp to count the frequency of each element of an array.*/

    public static void getFreq(int[] arr)
    {
        Dictionary<int,int> hashtable = new Dictionary<int, int>();


        foreach (int num in arr)
        {
            if (hashtable.ContainsKey(num))
            {
                hashtable[num] = hashtable[num] + 1;
            }
            else
            {
                hashtable[num] = 1;
            }
        }
        foreach (var num in hashtable)
        {
           Console.WriteLine(num);
        }

    }

    //6- Write a program in C# Sharp to find maximum and minimum element in an array

    public static void getMaxAndMin(int[] arr)
    {
        int max = 0;
        int min = 0;
        foreach (int num in arr) 
        {
            if (max < num)
            {
                max = num;
                min = num;
            }
            else
            {
                min = num;
            }
            
        }
        Console.WriteLine($"min = {min}");
        Console.WriteLine($"max = {max}");
    }

    //7- Write a program in C# Sharp to find the second largest element in an array.

    public static void getSecondLargestNum(int[] arr)
    
    {
    }

    /*
     10- Write a program to create two multidimensional arrays of same size.
        Accept value from user and store them in first array.
        Now copy all the elements of first array on second array and print second array.
     */

    public static void multidimensionalArrays(int row, int col)
    {

    }



    // 11- Write a Program to Print One Dimensional Array in Reverse Order

    public static void DimensionalArrayInReverse(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(arr[i]);
        }
    }

}
