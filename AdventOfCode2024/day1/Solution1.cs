using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    internal class Solution1
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
            list1.Sort();
            list2.Sort();

            for (int i = 0; i < list1.Count; i++) 
            {
                answer += Math.Abs(list1[i] - list2[i]);
            }
            return answer;

        }
    }
}
