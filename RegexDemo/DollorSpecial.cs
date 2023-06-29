using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class DollorSpecial
    {
        public static void Demo()
        {
            Regex regex = new Regex(@"ismail$");
            Match match = regex.Match("my name is ismail");
            if (match.Success)
            {
                Console.WriteLine("match value : " + match.Value);
            }

        }
    }
}
