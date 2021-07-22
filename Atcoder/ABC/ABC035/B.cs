using System;
using CoderCommon;

namespace Atcoder.ABC.ABC035
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var S = Console.ReadLine();
            var t = int.Parse(Console.ReadLine());
            int[] posXY = new int[2];
            int count = 0;
            foreach (var s in S)
            {
                switch (s)
                {
                    case 'L':
                        posXY[0]--;
                        break;
                    case 'R':
                        posXY[0]++;
                        break;
                    case 'U':
                        posXY[1]++;
                        break;
                    case 'D':
                        posXY[1]--;
                        break;
                    default:
                        count++;
                        break;
                }
            }

            var x = Math.Abs(posXY[0]);
            var y = Math.Abs(posXY[1]);
            if (t == 1)
            {
                Console.WriteLine(x + y + count);

            }
            else
            {
                if (x + y < count)
                {
                    var isZero = (count - (x + y)) % 2 == 0;
                    Console.WriteLine(isZero ? 0 : 1);
                }
                else
                {
                    Console.WriteLine(x + y - count);
                }
            }
        }
    }
}