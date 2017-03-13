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
        //Iteration
        //public int solution(int N)
        //{
        //    // write your code in C# 6.0 with .NET 4.5 (Mono)
        //    var result = Convert.ToString(N, 2);
        //    int longest = 0;
        //    int length = 0;
        //    for (int i = 0; i < result.Length; i++)
        //    {
        //        if (result[i] == '0')
        //            length += 1;
        //        else
        //        {
        //            if (length > longest) { longest = length; }
        //            length = 0;
        //        }
        //    }
        //    //Console.WriteLine(result);
        //    //Console.WriteLine(longest);
        //    return longest;
        //}

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
