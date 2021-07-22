using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC036
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var AB = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ret = AB[1] / AB[0];
            if (AB[1] % AB[0] != 0)
            {
                ret++;
            }
            Console.WriteLine(ret);
        }
    }
}