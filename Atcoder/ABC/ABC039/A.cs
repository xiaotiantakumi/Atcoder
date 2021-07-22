using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC039
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var ABC = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(ABC[0] * ABC[1] * 2 + ABC[1] * ABC[2] * 2 + ABC[0] * ABC[2] * 2);
        }
    }
}