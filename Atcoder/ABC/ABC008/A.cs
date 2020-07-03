using System;
using System.Linq;

namespace Atcoder.ABC.ABC008
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var ST = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(ST[1] - ST[0] + 1);
        }
    }
}