using System;
using CoderCommon;

namespace Atcoder.ABC.ABC196
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var s = Console.ReadLine();
            var pos = s.IndexOf(".");
            if (pos == -1)
            {
                Console.WriteLine(s);
                return;
            }

            Console.WriteLine(s.Substring(0, pos));
        }
    }
}