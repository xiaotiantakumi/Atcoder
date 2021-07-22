using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC168
{
    public class A : CoderBase
    {
        public override  void Run()
        {
            var r = Console.ReadLine();
            var hon = new int[] { 2, 4, 5, 9, 7 };
            var pon = new int[] { 0, 1, 6, 8 };
            var bon = new int[] { 3 };
            var target = int.Parse(r.Last().ToString());
            if (bon.Contains(target))
            {
                Console.WriteLine("bon");
            }
            else if (hon.Contains(target))
            {
                Console.WriteLine("hon");
            }
            else if (pon.Contains(target))
            {
                Console.WriteLine("pon");
            }
        }
    }
}