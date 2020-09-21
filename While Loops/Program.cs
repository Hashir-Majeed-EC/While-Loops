using System;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            enterNums();
        }
        static int[] bubbleSort(int[] nums)
        {
            bool swapped = false;
            int temp;

            while (!swapped)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = 0; j < nums.Length - i - 1; j++)
                    {
                        if (nums[j] > nums[j + 1])
                        {
                            //swap nums[j] and nums[j + 1]
                            temp = nums[j];
                            nums[j] = nums[j + 1];
                            nums[j + 1] = temp;
                        }
                    }
                }
            }
           
            return nums;
        }

        static void enterNums()
        {
            int count = 0;
            int input = 0;
            const int breakOut = -1;
            do
            {
                try
                {
                    Console.WriteLine("Enter a number: ");
                    input = Convert.ToInt32(Console.ReadLine());
                    count++;
                } catch
                {
                    Console.WriteLine("Not a number.");
                }
                
            } while (input != breakOut && count != 5);
        }

        static void insertionSort()
        {
            /*Step 1 − If it is the first element, it is already sorted. return 1;
            Step 2 − Pick next element
            Step 3 − Compare with all elements in the sorted sub - list
            Step 4 − Shift all the elements in the sorted sub - list that is greater than the
            value to be sorted
            Step 5 − Insert the value
            Step 6 − Repeat until list is sorted*/




        }

        static void compareVals(int[] nums)
        {
            int count = 1;
            do
            {
                if(nums[nums.Length - 1] <= nums[nums.Length - count])
                {
                    swap(nums, nums.Length - 1, nums.Length - count);
                }
            }while ()
        }

        static int[] swap(int nums[], int val1, int val2)
        {
            int temp
        }

    }
}
