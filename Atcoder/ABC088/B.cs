using System;
using System.Linq;

namespace Atcoder.ABC088
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            bool isAlice = true;
            int alicePoint = 0;
            int bobPoint = 0;
            var points = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).ToArray();

            for (int i = 0; i < N; i++)
            {
                int tmpPoint = points[i];
                if (isAlice)
                {
                    alicePoint += tmpPoint;
                    isAlice = false;
                }
                else
                {
                    bobPoint += tmpPoint;
                    isAlice = true;
                }
            }
            Console.WriteLine(alicePoint - bobPoint);
        }
    }
}