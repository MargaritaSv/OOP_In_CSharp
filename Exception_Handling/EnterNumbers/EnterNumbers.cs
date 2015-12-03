using System;
using System.Linq;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                int maxEls = nums.Max();
                int min = Math.Min(2,maxEls+1);
                int max = 100 - 10 + i;

                Console.WriteLine("Enter the number: ");
                nums[i] = ReadNumber(min,max);
            }

        }

        public static int ReadNumber(int strat, int end)
        {
            string input = Console.ReadLine();
            try
            {
                int num = int.Parse(input);
                if (num < strat || num > end)
                {
                    throw new ArgumentOutOfRangeException("number", string.Format("Number should be between {0} and {1}", strat, end));
                }

                return num;
            }
            catch (Exception)
            {
                Console.WriteLine("Number should be in the range [{0} .... {1}].Enter again:",strat,end);
                return ReadNumber(strat, end);
            }

        }
    }
}
