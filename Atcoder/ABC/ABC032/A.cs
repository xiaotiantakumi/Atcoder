using System;
using CoderCommon;

namespace Atcoder.ABC.ABC032
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            while (true)
            {
                if (n % a == 0 && n % b == 0)
                {
                    Console.WriteLine(n);
                    return;
                }
                n++;
            }
        }
    }
}