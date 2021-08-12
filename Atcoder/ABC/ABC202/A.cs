using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC202
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var abc = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ret = 0;
            foreach (var item in abc)
            {
                ret += (7 - item);
            }

            Console.WriteLine(ret);
        }
    }
}