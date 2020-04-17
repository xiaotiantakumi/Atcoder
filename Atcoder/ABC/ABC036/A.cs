using System;
using System.Linq;

namespace Atcoder.ABC036
{
    public class A : AtcoderBase
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