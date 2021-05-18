using System;
using System.Linq;

namespace Atcoder.ABC.ABC195
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var MH = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ret = MH[1] % MH[0] == 0;
            Console.WriteLine(ret ? "Yes" : "No");
        }
    }
}