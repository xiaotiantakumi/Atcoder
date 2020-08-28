using System;
using System.Linq;

namespace Atcoder.ABC.ABC021
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var ab = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var K = int.Parse(Console.ReadLine());
            var Ps = Console.ReadLine().Split().Select(int.Parse).ToList();
            Ps.AddRange(ab);
            var count = Ps.Count();
            var count2 = Ps.Distinct().Count();
            if (count == count2)
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