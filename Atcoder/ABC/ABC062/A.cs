using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC062
{
    public class A : CoderBase
    {
        public override void Run()
        {
            var aGroup = new int[7] { 1, 3, 5, 7, 8, 10, 12 };
            var bGroup = new int[4] { 4, 6, 9, 11 };
            var r = ReadIntArray();
            if (aGroup.Contains(r[0]) && aGroup.Contains(r[1]) ||
                bGroup.Contains(r[0]) && bGroup.Contains(r[1]))
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