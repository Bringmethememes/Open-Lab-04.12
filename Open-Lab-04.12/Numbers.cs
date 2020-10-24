using System;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            int a = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                a = a + nums[i];
            }
            int pleb = 55 - a;
            return pleb;


            

            




        }
    }
}
