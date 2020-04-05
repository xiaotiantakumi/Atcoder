using System;
using System.Linq;

namespace Atcoder.ABC.ABC161
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var zan = NK[0] % NK[1];
            var ret = Math.Min(zan, Math.Abs(zan - NK[1]));
            if (NK[1] == 1)
            {
                Console.WriteLine("0");
                return;
            }

            Console.WriteLine(ret);
        }
    }
}