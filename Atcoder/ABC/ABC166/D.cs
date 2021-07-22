using System;
using CoderCommon;

namespace Atcoder.ABC.ABC166
{
    public class D : CoderBase
    {
        public override void Run()
        {
            var X = int.Parse(Console.ReadLine());
            for (int i = -1000; i < 1000; i++)
            {
                for (int j = -1000; j < 1000; j++)
                {
                    if (X == (long)Math.Pow(i, 5) - (long)Math.Pow(j, 5))
                    {
                        Console.WriteLine(i.ToString() + " " + j.ToString());
                        return;
                    }
                }
            }
        }
    }
}