/* Program: Deliverable(2)
 * Date: 07/07/2023
 * Author: Nathan Nguyen
 */
using System;
namespace Deliverable_2_
{
     class Program
    {
        static int [] number_array (int array_len)
        {
            Random number = new Random();
            int [] MyArray = new int [array_len];
            for (int i = 0; i < array_len; i++)
            {
                MyArray[i] = number.Next(10, 50);
            }
            return MyArray;
        }
        static int sum (int[] array)
        {
            int sum = 0;
            foreach (int item in  array) 
            { 
            sum += item; 
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Boolean done = false;
            while (!done) 
            {
                try
                {
                    Console.WriteLine("Please enter an integer number between 5 and 15.");
                   int input = int.Parse(Console.ReadLine());
                    if (input >= 5 && input <= 15)
                    {
                        int[] InputArray = number_array(input);
                        Console.WriteLine(" The random numbers are: ");
                        foreach (int element in InputArray)
                        {
                            Console.WriteLine(element);
                        }
                        Console.WriteLine("The sum of random numbers is: " + sum(InputArray));
                        done = true;
                    }
                 
                }
                catch (Exception e) { } 
            
            }
        }
    }
}