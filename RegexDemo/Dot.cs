using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class Dot
    {
        public static void Demo()
        {
            Regex regex = new Regex(@"n..t");
            Match match = regex.Match("my name is not noot ismail");
            if (match.Success)
            {
                Console.WriteLine("match value : " + match.Value);
            }

        }
    }
}
