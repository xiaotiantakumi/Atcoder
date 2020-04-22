using System;
using System.Linq;

namespace Atcoder.ABC.ABC038
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var WH1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var WH2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (WH1[0] == WH2[0] || WH1[0] == WH2[1] ||
                WH1[1] == WH2[0] || WH1[1] == WH2[1])
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}