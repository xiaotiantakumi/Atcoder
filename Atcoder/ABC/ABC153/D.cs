using System;

namespace Atcoder.ABC153
{
    public class D : AtcoderBase
    {
        public override void Run()
        {
            var H = long.Parse(Console.ReadLine());
            long numEnemy = 1;
            long attackCount = 0;
            while (H != 1)
            {
                attackCount += numEnemy;
                numEnemy *= 2;
                H /= 2;
            }
            Console.WriteLine(numEnemy + attackCount);
        }
    }
}