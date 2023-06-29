using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class SquareBrakets
    {
        public static void Demo()
        {
            Regex regex = new Regex(@"[abc]");
            Match match = regex.Match("my b.name is ismail");
            if (match.Success)
            {
                Console.WriteLine("match value : " + match.Value);
            }

        }
    }
}
