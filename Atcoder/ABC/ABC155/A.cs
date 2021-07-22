using System;
using CoderCommon;

namespace Atcoder.ABC155
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r = ReadIntArray();
            if ((r[0] == r[1] || r[1] == r[2] || r[0] == r[2]) && !(r[0] == r[1] && r[1] == r[2]))
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