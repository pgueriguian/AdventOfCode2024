using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Solution2
    {
        public static int Solve()
        {
            int answer = 0;
            string filePath = "input.txt";

            foreach (string line in File.ReadLines(filePath))
            {
                var vals = line.Split(" ");
                var ints = vals.Select(e => Convert.ToInt16(e)).ToList();
                

                for (int a = 0; a < ints.Count; a++)
                {
                    bool badsequence = false;
                    var IntsLessOne = ints.ToList();
                    IntsLessOne.RemoveAt(a);
                    bool ascending = IntsLessOne[1] > IntsLessOne[0];
                    for (int i = 1; i < IntsLessOne.Count; i++)
                    {
                        if (IntsLessOne[i] > IntsLessOne[i - 1] != ascending)
                        {
                            badsequence = true;
                            break;
                        }

                        int delta = Math.Abs(IntsLessOne[i] - IntsLessOne[i - 1]);
                        if (delta > 3 || delta == 0)
                        {
                            badsequence = true;
                            break;
                        }
                    }

                    if (!badsequence)
                    {
                        answer++;
                        break;
                    }
                }
                
            }

            return answer;
        }
    }
}
