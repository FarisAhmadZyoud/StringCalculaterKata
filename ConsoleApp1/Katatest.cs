using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestingOfAddMethod
{
    public class Katatest
    {

        public int add(string Numbers)
        {


            char[] delimiterChars = { ';', ',', '.', ':', '\t' };

            if (Numbers == "")
            {
                return 0;


            }
            else
            {
                bool line = Numbers.Contains("\n");
                if (line == true) Numbers.Split('\n');

                int[] nums = Array.ConvertAll(Numbers.Split(delimiterChars), int.Parse);

                if (nums.Length == 1) return nums[0];

                for (var i = 0; i < nums.Length; i++)
                {
                    if (nums[i] >= 1000) nums[i] = 0;
                   if (nums[i]<0) throw new NegativeNumberNotAllowed("Negative number is not allowed" + nums[i]);

                }
                var result = nums.Sum();
                return result;
            }






        }




    }
   

    
}
