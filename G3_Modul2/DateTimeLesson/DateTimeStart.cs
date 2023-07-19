using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace G3_Modul2.DateTimeLesson
{
    internal class DateTimeStart
    {
        public static void Run()
        {
            //DateTime dateTime = DateTime.Now;

            //Console.WriteLine(dateTime);
            //Console.WriteLine(DateTime.UtcNow);
            //Console.WriteLine(DateTime.Today);
            //Console.WriteLine(DateTime.MinValue);
            //Console.WriteLine(DateTime.MaxValue);
            //Console.WriteLine(dateTime.Subtract(DateTime.UtcNow));
            //Console.WriteLine(DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Unspecified));
            //Console.WriteLine(TimeSpan.FromTicks(1).Ticks);
            //Console.WriteLine(dateTime.AddTicks(5400000));

            //DateOnly dateOnly = DateOnly.Parse(DateTime.Now.ToLongDateString());



            //Console.WriteLine(DateTime.Today.ToShortDateString());

            //TimeOnly timeOnly =TimeOnly.Parse(DateTime.Now.ToLongTimeString());


            //Console.WriteLine(timeOnly);


            //Console.WriteLine("Sleep");


            //System.Timers.Timer timer=new System.Timers.Timer();


            //timer.Elapsed += (sender, arg) =>
            //{
            //    Console.WriteLine(arg.SignalTime);
            //}; 


            //timer.Start();
            //timer.Interval = 1000;
            //Thread.Sleep(TimeSpan.FromSeconds(4));
            ////func
            //timer.Stop();

            //timer.Dispose();


            //string a = "hello";
            //string b = "Hello";

            ////Console.WriteLine(a.Equals(b));

            //Regex regex = new Regex("^[a-eA-E]");
            //Regex regex1 = new Regex("^[a-zA-Z]$[o]");

            //Console.WriteLine(regex.IsMatch(b));
            //Console.WriteLine(regex1.IsMatch(a));

            /*
 * ^ - Starts with
 * $ - Ends with
 * [] - Range
 * () - Group
 * . - Single character once
 * + - one or more characters in a row
 * ? - optional preceding character match
 * \ - escape character
 * \n - New line
 * \d - Digit
 * \D - Non-digit
 * \s - White space
 * \S - non-white space
 * \w - alphanumeric/underscore character (word chars)
 * \W - non-word characters
 * {x,y} - Repeat low (x) to high (y) (no "y" means at least x, no ",y" means that many)
 * (x|y) - Alternative - x or y
 * 
 * [^x] - Anything but x (where x is whatever character you want)
 */

            // (440) 555-1212
            // 12-34567890
            // 123 87876

            //string toSearch = File.ReadAllText("test.txt");

            // This pattern matches phone numbers in the following patterns
            //string pattern = @"\(?\d{3}\)?(-|.|\s)?\d{3}(-|.)?\d{4}";

            // MatchCollection matches = Regex.Matches(toSearch, pattern);

            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match.Value);
            //}

            string pattern = @"(\s|^)Tim([^b]|$)";// (\s|$)";
            string toSearch = "Tim Corey";

            Console.WriteLine("Tim Corey: " + Regex.IsMatch("Tim Corey", pattern));
            Console.WriteLine("Timothy Corey: " + Regex.IsMatch("Timothy Corey", pattern));
            Console.WriteLine("Always Tim: " + Regex.IsMatch("Always Tim", pattern));
            Console.WriteLine("I Am Tim Corey: " + Regex.IsMatch("I Am Tim Corey", pattern));

            //Stopwatch stopwatch = new();

            //stopwatch.Start();
            //Regex test = new Regex(pattern);

            //for (int i = 0; i < 100000; i++)
            //{
            //    //Regex.IsMatch("I Am Tim Corey", pattern);
            //    test.IsMatch("I Am Tim Corey");
            //}

            //stopwatch.Stop();

            //Console.WriteLine($"Time Elapsed in ms: {stopwatch.ElapsedMilliseconds}");
        }
    }
}
