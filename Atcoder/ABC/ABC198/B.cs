using System;
using System.Linq;

namespace Atcoder.ABC.ABC198
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = Console.ReadLine();
            var left = int.Parse(new string(N.Reverse().ToArray()));
            var right = int.Parse(new string(left.ToString().Reverse().ToArray()));
            if (left == right)
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