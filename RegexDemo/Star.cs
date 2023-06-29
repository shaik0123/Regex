using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class Star
    {
        public static void Demo()
        {
            Regex regex = new Regex(@"a*b");
            Match match = regex.Match("aabcdb");
            if (match.Success) 
            {
                Console.WriteLine("match value : "+match.Value);
            }

        }
    }
}
