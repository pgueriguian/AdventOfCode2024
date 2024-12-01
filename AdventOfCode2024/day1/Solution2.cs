using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    internal class Solution2
    {
        public static int Solve()
        {
            int answer = 0;
            string filePath = "input.txt";
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();

            foreach (string line in File.ReadLines(filePath))
            {
                var vals = line.Split("   ");
                list1.Add(Convert.ToInt32(vals[0]));
                list2.Add(Convert.ToInt32(vals[1]));
            }

            for (int i = 0; i < list1.Count; i++)
            {
                answer += list1[i] * list2.Count(e => e == list1[i]);
            }
            return answer;

        }
    }
}
