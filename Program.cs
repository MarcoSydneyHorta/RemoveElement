using System;

namespace RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer array separated by space = ");
            int[] nums = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            Console.Write("Enter a number that you desired to remove from above array = ");
            int val = int.Parse(Console.ReadLine());
            int res = RemoveElement(nums, val);

            Console.Write("The new array is = ");
            for (int i = 0; i < res; i++)
            {
                if (i == res - 1)
                {
                    Console.WriteLine(nums[i]);
                }
                else
                {
                    Console.Write(nums[i] + " , ");
                }
            }
        }


        public static int RemoveElement(int[] nums, int val)
        {
            int size = nums.Length;
            int nsize = size;
            int ne = nsize;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < nsize; j++)
                {
                    if (nums[j] == val)
                    {
                        nums[j] = nums[nsize - 1];
                        nums[nsize - 1] = -1;
                        ne--;
                        break;
                    }
                }
                nsize--;
            }
            return ne;
        }
    }
}
