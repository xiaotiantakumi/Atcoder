using System;
using System.Linq;

namespace Atcoder.ABC037
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var ABC = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(ABC[2] / Math.Min(ABC[0], ABC[1]));
        }
    }
}