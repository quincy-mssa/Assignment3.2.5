﻿namespace Assignment3._2._5
{
    internal class Program
    {
        //Create a function that finds the index of a given item in the array
        //Examples
        //Search([1, 5, 3], 5) ➞ 1
        //Search([9, 8, 3], 3) ➞ 2
        //Search([1, 2, 3], 4) ➞ -1
        //Notes
        //If the item is not present, return -1.
        static void Main(string[] args)
        {
            Console.WriteLine(Search(new int[] { 1, 5, 3 }, 5)); 
            Console.WriteLine(Search(new int[] { 9, 8, 3 }, 3)); 
            Console.WriteLine(Search(new int[] { 1, 2, 3 }, 4)); 
        }

        public static int Search(int[] arr, int item)
        {
            //Loop to find the index of the item
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item)
                {
                    return i;
                }
            }
            //return -1 if the item is not found
            return -1;
        }
    }
}
