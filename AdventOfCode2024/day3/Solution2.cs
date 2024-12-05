using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace day3
{
    internal class Solution2
    {
        public static int Solve()
        {
            int answer = 0;
            string filePath = "input.txt";
            string content = File.ReadAllText(filePath);
            string[] delimiters = { "don't()", "do()" };
            string splitPattern = string.Join("|", Array.ConvertAll(delimiters, Regex.Escape));
            string[] result = Regex.Split(content, $"(?={splitPattern})|(?<={splitPattern})");

            bool doing = true;
            foreach (string line in result) 
            {
                if (line == "don't()")
                {
                    doing = false;
                }
                else if (line == "do()")
                {
                    doing = true;
                }
                else if (doing)
                {
                    string pattern = @"mul\((\d{1,3}),(\d{1,3})\)";
                    MatchCollection matches = Regex.Matches(line, pattern);
                    foreach (Match match in matches)
                    {
                        answer += int.Parse(match.Groups[1].Value) * int.Parse(match.Groups[2].Value);
                    }
                }
            }
            return answer;
        }
    }
}
