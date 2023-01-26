using System;

namespace RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;
            int res = RemoveElement(nums, val);
            Console.WriteLine("nums size now is = " + res);
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
