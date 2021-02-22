/*
 * 
 * ARRAY SELF PRACTICE
 * Daniel Tibbotts
 * 22/02/2021
 * 
 */

using System;

namespace ArraySelfPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Practice creating one-dimensional arrays containing different element types and of different length. 
            int[] grades = new int[4];
            string[] countries = new string[3];
            decimal[] costs = new decimal[6] { 10.09M, 11.99M, 12.50M, 8.99M, 7.20M, 5.15M };


            // Try adding elements to those arrays and displaying the elements in the console. 
            grades[0] = 50;
            grades[1] = 60;
            grades[2] = 70;
            grades[3] = 80;

            countries[0] = "New Zealand";
            countries[1] = "Australia";
            countries[2] = "India";


            // Practice displaying only specific array elements by referring to its index as well as 
            // displaying all the elements of array using the for loop.

            Console.WriteLine(grades[0]);
            Console.WriteLine(countries[2]);
            Console.WriteLine(costs[5]);

            for (int i = 0; i < costs.Length; i++)
            {
                Console.WriteLine($"The cost is { costs[i] }");
            }



            // Add an incorrect data type element to an array and note whether a compiler or a runtime error occurs.

            costs[2] = 12.50 // Note: Compile Error, expected decimal received double

            Console.ReadLine();
        }
    }
}
