using System;
using System.Linq;

namespace Atcoder.ABC039
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var ABC = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(ABC[0] * ABC[1] * 2 + ABC[1] * ABC[2] * 2 + ABC[0] * ABC[2] * 2);
        }
    }
}