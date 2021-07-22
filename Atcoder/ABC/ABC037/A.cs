using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC037
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var ABC = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(ABC[2] / Math.Min(ABC[0], ABC[1]));
        }
    }
}