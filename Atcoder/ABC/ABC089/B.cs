using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC089
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var r = int.Parse(Console.ReadLine());
            var l = Console.ReadLine().Split(' ');
            if (l.Any(x => x == "Y"))
            {
                Console.WriteLine("Four");
            }
            else
            {
                Console.WriteLine("Three");

            }
        }
    }
}