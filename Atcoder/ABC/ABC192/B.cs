using System;
using CoderCommon;

namespace Atcoder.ABC.ABC192
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine();
            for (int i = 0; i < r.Length; i++)
            {
                if ((i % 2 == 0 && char.IsUpper(r[i])) ||
                    (i % 2 == 1 && char.IsLower(r[i])))
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}