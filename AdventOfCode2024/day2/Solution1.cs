using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Solution1
    {
        public static int Solve()
        {
            int answer = 0;
            string filePath = "input.txt";

            foreach (string line in File.ReadLines(filePath))
            {
                bool isValid = true;
                var vals = line.Split(" ");
                var ints = vals.Select(e => Convert.ToInt16(e)).ToList();
                bool ascending = ints[1] > ints[0];
                for (int i = 1; i < ints.Count; i++) 
                {
                    if (ints[i] > ints[i-1] != ascending) 
                    {
                        isValid = false;
                        break;
                    }

                    int delta = Math.Abs(ints[i] - ints[i - 1]);
                    if (delta > 3 || delta == 0)
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    answer++;
                }
            }

            return answer;
        }
    }
}
