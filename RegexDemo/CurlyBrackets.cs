using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class CurlyBrackets
    {
        public static void Demo()
        {
            Regex regex = new Regex(@"(my)");
            Match match = regex.Match("mymy my name is ismail ");
            if (match.Success)
            {
                Console.WriteLine("match value : " + match.Value);
            }

        }
    }
}
