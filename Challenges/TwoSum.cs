using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{

    /*
     * Challenge name: Two-Sum-II-Data-Structure-design
        Description: Designed and implemented a TwoSum class. This class should support the following operations:
        add and find. add: Adds the number to an internal data structure. 
        find: Finds if there exists a pair of numbers
        whose sum is equal to the given value. Please note that your returned answers (both index1 and index2) are not zero-based. 

        Example:
        add function
        Input: The numbers that will be entered into the data structure.

        find function
        Starting from the array created in the previous function, which is as follows: [2,7,11,15]
	        Input: target = 9
        Output: index1=1, index2=2
     */
    public static class TwoSum
    {
        public static List<int> data { get; set; } = new List<int>();

        public static bool Add(int number)
        {     
            if(number <= 0 )
                return false;

            data.Add(number);
            return data.Any();
        }

        public static Dictionary<int,int> Find(int value)
        {
            if (value < 0)
                return new Dictionary<int, int>();
            if(!data.Any())
                return new Dictionary<int, int>();             

            var result = new Dictionary<int,int>();
            var next = 1;
            for (int i = 0; i < data.Count; i++)
            {
                var current = i;
                if (data[current] + data[next] == value)
                {
                    result.Add(i, data[i]);
                    result.Add(next, data[next]);
                    break;
                }
                next++;
            }            
          return result;
        }
    }
}
