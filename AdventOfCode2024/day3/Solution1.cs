using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace day3
{
    internal class Solution1
    {
        public static int Solve()
        {
            int answer = 0;
            string filePath = "input.txt";
            string content = File.ReadAllText(filePath);
            string pattern = @"mul\((\d{1,3}),(\d{1,3})\)";
            MatchCollection matches = Regex.Matches(content, pattern);
            foreach (Match match in matches)
            {
                answer += int.Parse(match.Groups[1].Value) * int.Parse(match.Groups[2].Value);
            }
            return answer;  
        }
    }
}
