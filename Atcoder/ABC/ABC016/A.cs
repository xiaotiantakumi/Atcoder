using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC016
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (r[0] % r[1] == 0)
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