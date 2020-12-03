using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ARC.ARC045
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var s = Console.ReadLine().Split().ToArray();
            List<string> ret = new List<string>();
            foreach (var tar in s)
            {
                if (tar == "Left")
                {
                    ret.Add("<");
                }
                else if (tar == "Right")
                {
                    ret.Add(">");
                }
                else if (tar == "AtCoder")
                {
                    ret.Add("A");
                }
            }

            Console.WriteLine(string.Join(" ", ret));
        }
    }
}