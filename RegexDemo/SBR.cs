using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class SBR
    {
        public static void Demo()
        {
            Regex regex = new Regex(@"[a-d]");
            Match match = regex.Match("my name is ismail");
            if (match.Success)
            {
                Console.WriteLine("match value : " + match.Value);
            }

        }
    }
}
