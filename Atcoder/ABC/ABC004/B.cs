using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC004
{
    public class B : CoderBase
    {
        public override void Run()
        {
            List<string> input = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                input.Add(Console.ReadLine());
            }

            for (int i = 3; i >= 0; i--)
            {
                var tmp = input[i];
                Console.WriteLine(new string(tmp.Reverse().ToArray()));
            }
        }
    }
}