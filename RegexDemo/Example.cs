using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class Example
    {
        public static void Demo()
        {
            Regex regex = new Regex(@"\D");
            Match match = regex.Match("my 123 name is ismail");
            if (match.Success)
            {
                Console.WriteLine("match value : " + match.Value);
            }
            Regex regex1 = new Regex(@"\w");
            Match match1 = regex1.Match(" 123 My _name is ismail");
            if (match1.Success)
            {
                Console.WriteLine("match value1 : " + match1.Value);
            }
            Regex regex2 = new Regex(@"\W");
            Match match2 = regex2.Match("123 My _name $ is ismail");
            if (match2.Success)
            {
                Console.WriteLine("match value2 : " + match2.Value);
            }
            Regex regex3 = new Regex(@"\s");
            Match match3 = regex3.Match(" 123 My _name is ismail");
            if (match3.Success)
            {
                Console.WriteLine("match value3 : " + match3.Value);
            }

        }
    }
}
