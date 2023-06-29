using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public class BackSlashd
    {
        public static void Demo()
        {
            Regex regex = new Regex(@"\d");
            Match match = regex.Match("i want  0,10,20 rps");
            if (match.Success)
            {
                Console.WriteLine("match value : " + match.Value);
            }

        }
    }
}
