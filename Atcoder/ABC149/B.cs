using System;
using System.Linq;

namespace Atcoder.ABC149
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var A = r[0];
            var B = r[1];
            var K = r[2];
            if (K > A)
            {
                var t = (B - (K - A)) < 0 ? 0 : (B - (K - A));
                Console.WriteLine("0 " + t.ToString());
            }
            else
            {
                Console.WriteLine((A - K).ToString() + " " + B);
            }
        }
    }
}