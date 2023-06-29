using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class Plus
    {
        public static void Demo()
        {
            Regex regex = new Regex(@"a+b+c");
            Match match = regex.Match("aaabcdbc");
            if (match.Success)
            {
                Console.WriteLine("match value : " + match.Value);
            }

        }
    }
}
