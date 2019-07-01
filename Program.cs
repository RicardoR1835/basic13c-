using System;
using System.Collections.Generic;

namespace basic13
{
    class Program
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 255; i++)
            {

                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            for (int i = 1; i <= 255; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum = sum + i;
                Console.WriteLine($"New number: {i}  Sum: {sum}");
            }
        }
        public static void LoopArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static int FindMax(int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            Console.WriteLine(max);
            return max;
        }

        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            int avg = sum / numbers.Length;
            Console.WriteLine(avg);
        }

        public static int[] OddArray()
        {
            List<int> odds = new List<int>();
            for (int i = 1; i < 255; i = i + 2)
            {
                odds.Add(i);
            }
            int[] odd = odds.ToArray();
            for (int i = 0; i < odd.Length; i++)
            {
                Console.WriteLine(odd[i]);
            }
            Console.WriteLine(odd);
            return odd;
        }
        public static int GreaterThanY(int[] num, int y)
        {
            int count = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > y)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            return count;
        }
        public static void SquareArrayValues(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        public static void EliminateNegatives(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    nums[i] = 0;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        public static void MinMaxAverage(int[] nums)
        {
            int min = nums[0];
            int max = nums[0];
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            int avg = sum / nums.Length;
            Console.WriteLine($"Max: {max} Min: {min} Avg: {avg}");
        }
        public static void ShiftValues(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == nums[nums.Length - 1])
                {
                    nums[i] = 0;
                }
                else
                {
                    nums[i] = nums[i + 1];
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        public static object[] NumToString(int[] nums){
            List<object> arr = new List<object>();
            for(int i = 0; i < nums.Length; i++){
                if(nums[i] < 0){
                    nums[i].ToString("Dojo");
                }
                arr.Add(nums[i]);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            return arr;
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
        }

        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // int[] arr = {1,4,67,3,8,9,2};
            // LoopArray(arr);
            // int[] arr = {-5,-3,-6,-2,55,-9,-8};
            // FindMax(arr);
            // int[] arr = {1,4,5,10,9,2};
            // GetAverage(arr);
            // OddArray();
            // int [] num = {-1,0,3,5,2,8,7,9};
            // int y = 6;
            // GreaterThanY(num,y);
            // int[] nums = {2,3,4,5};
            // SquareArrayValues(nums);
            // int[] nums = { -1, -2, -4, 5, 6, 7 };
            // EliminateNegatives(nums);
            // int[] nums = {2,3,4,5};
            // MinMaxAverage(nums);
            // int[] nums = {1, 5, 10, 7, -2};
            // ShiftValues(nums);
            int[] nums = {-1, -3, 2};
            NumToString(nums);
        }
    }
}
