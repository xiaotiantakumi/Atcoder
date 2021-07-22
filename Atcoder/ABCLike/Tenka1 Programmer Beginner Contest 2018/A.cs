using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABCLike.Tenka1_Programmer_Beginner_Contest_2018
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var s = Console.ReadLine();
            if (s.Length == 3)
            {
                s = new string(s.Reverse().ToArray());
            }

            Console.WriteLine(s);
        }
    }
}