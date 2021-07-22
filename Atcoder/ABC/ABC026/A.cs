using System;
using CoderCommon;

namespace Atcoder.ABC.ABC026
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var A = int.Parse(Console.ReadLine());
            if (A % 2 == 0)
            {
                Console.WriteLine(A / 2 * A / 2);
            }
            else
            {
                var tmp = A / 2;
                Console.WriteLine(tmp * (tmp + 1));
            }
        }
    }
}