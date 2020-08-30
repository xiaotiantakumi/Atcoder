using System;
using System.Linq;

namespace Atcoder.ABC.ABC177
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var DTS = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (DTS[0] <= DTS[1] * DTS[2])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}