using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.solution(1041,0));
            Console.ReadLine();
        }
    }

    class Solution
    {
        
        int longest, length=0;
        string result;

        public int solution(int N, int i)
        {

                result = Convert.ToString(N, 2);

                if (i < result.Length)
                {
                    if (result[i] == '0')
                        length += 1;
                    else
                    {
                        if (length > longest) { longest = length; }
                        length = 0;
                    }
                    i++;
                    solution(N, i);
                }
                else
                    return longest;
            return longest;
        }
    }
}
