using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC082
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var s = new string(Console.ReadLine().OrderBy(x => x).ToArray());
            var t = new string(Console.ReadLine().OrderByDescending(x => x).ToArray());
            if (s.CompareTo(t) < 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}