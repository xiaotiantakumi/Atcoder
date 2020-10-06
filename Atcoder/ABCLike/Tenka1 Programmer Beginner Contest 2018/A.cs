using System;
using System.Linq;

namespace Atcoder.ABCLike.Tenka1_Programmer_Beginner_Contest_2018
{
    public class A : AtcoderBase
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