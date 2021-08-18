using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC212
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var s = Console.ReadLine();
            bool isWeak = false;
            var c = s[0];
            isWeak = s.All(x => x == c);

            if (isWeak)
            {
                Console.WriteLine("Weak");
                return;
            }

            bool flg = false;
            for (int i = 1; i < s.Length; i++)
            {
                var pre = int.Parse(s[i - 1].ToString());
                var current = int.Parse(s[i].ToString());
                if ((pre == 9 && current == 0) || pre + 1 == current)
                {
                }
                else
                {
                    flg = true;
                }
            }

            if (!flg)
            {
                Console.WriteLine("Weak");
                return;
            }
            Console.WriteLine("Strong");
        }
    }
}