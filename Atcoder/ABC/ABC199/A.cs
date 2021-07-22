using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC199
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var ABC = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Math.Pow(ABC[0], 2) + Math.Pow(ABC[1], 2) < Math.Pow(ABC[2], 2) ? "Yes" : "No");
        }
    }
}