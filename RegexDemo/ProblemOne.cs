using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    public  class ProblemOne
    {
        public static void DemoOne()
        {
            Regex regex = new Regex(@"ab+");
            Match match = regex.Match("aabbccbbb");
            if (match.Success) 
            {
                Console.WriteLine(match.Value);

            }
        }
        public static void DemoTwo()
        {
            Regex regex1 = new Regex(@"[a-z]+(?:_[a-z]+)+");
            Match match1 = regex1.Match("A_a_c_dB_b_cDAF");
            if (match1.Success)
            {
                Console.WriteLine(match1.Value);

            }
        }
        public static void DemoThree()
        {
            Regex regex2 = new Regex(@"<[^>]+>");
             string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";
            MatchCollection match2 = regex2.Matches(input);//mul input
            foreach(Match m in match2)
            {
                Console.WriteLine(m.Value);
            }
            
        }
        public static void DemoFive()
        {
            Regex regex4 = new Regex("^(([A-za-z]{2,})+(.)+[a-zA-z]{3,4})");
            Match match4 = regex4.Match("somthing.jpg");
            if (match4.Success)
            {
                Console.WriteLine(match4.Value);
            }
        } 
        public static void DemoSix() 
        {
            Regex regex5 = new Regex("^(([a-z]{4,})+(.)+(www.)+([A-za-z]{2,})+(.)+[a-z]{2,3})$");
            Match match5 = regex5.Match("http:\\www.BridgeLabz.com");
            if (match5.Success)
            {
                Console.WriteLine(match5.Value);
            }
        }

    }
}
