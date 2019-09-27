using System;
using System.Diagnostics;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "07:05:45PM";
            Debug.Print(timeConversion(s));
        }
        static string timeConversion(string s)
        {
            int hr = Convert.ToInt32(s.Substring(0, 2));
            string timeWithoutHr = s.Substring(2, s.Length - 4);
            string newTime;
            if (hr == 12 && s.EndsWith("AM"))
            {
                hr = 0;
            }
            else if (hr == 12 && s.EndsWith("PM"))
            {
                hr = 12;
            }
            else if (s.EndsWith("PM"))
            {
                hr += 12;
            }

            if (hr < 10)
            {
                newTime = "0" + hr + timeWithoutHr;
            }
            else
            {
                newTime = hr + timeWithoutHr;
            }
            return newTime;
        }
    }
}
