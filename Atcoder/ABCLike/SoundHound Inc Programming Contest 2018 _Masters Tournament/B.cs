using System;
using CoderCommon;

namespace Atcoder.ABCLike.SoundHound_Inc_Programming_Contest_2018__Masters_Tournament
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var s = Console.ReadLine();
            var w = int.Parse(Console.ReadLine());
            string ret = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (i % w == 0)
                {
                    ret += s[i];
                }
            }

            Console.WriteLine(ret);
        }
    }
}