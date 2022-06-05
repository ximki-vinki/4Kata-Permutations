using System;
using System.Collections.Generic;
using System.Linq;

namespace _4Kata_Permutations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ab";
            var a = Permutations.SinglePermutations(s);
            Console.WriteLine();
        }
    }
    class Permutations
    {
        static List<string> Answer;

        public static List<string> SinglePermutations(string s)
        {
            Answer = new List<string>();
            char[] sArray = s.ToCharArray();

            Perm(sArray, 0, s.Length);
            return Answer.Distinct().ToList();
        }
        private static void Perm(char[] sArray, int curr, int maxCurr)
        {
            if (curr == maxCurr)
            {
                Answer.Add(new string(sArray));
                return;
            }
            for (int i = curr; i < maxCurr; i++)
            {
                Swap(sArray, i, curr);
                Perm(sArray, curr + 1, maxCurr);
                Swap(sArray, i, curr);
            }
        }
        private static void Swap(char[] sArray, int i, int curr)
        {
            var temp = sArray[i];
            sArray[i] = sArray[curr];
            sArray[curr] = temp;
        }
    }


}
