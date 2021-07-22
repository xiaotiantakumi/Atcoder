using System;
using System.Collections.Generic;
using CoderCommon;

namespace Atcoder.ARC.ARC012
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            List<string> weeks = new List<string>()
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            var s = Console.ReadLine();
            var ret = 5 - weeks.IndexOf(s);
            Console.WriteLine(ret < 0 ? 0 : ret);
        }
    }
}