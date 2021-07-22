using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC086
{
    public class C : CoderBase
    {
        public override void Run()
        {
            var points = int.Parse(Console.ReadLine());
            bool flg = true;
            int fromX = 0;
            int fromY = 0;
            int startTime = 0;
            for (int i = 0; i < points; i++)
            {
                var r = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                flg = CanArrive(fromX, fromY, r[1], r[2], startTime, r[0]);
                fromX = r[1];
                fromY = r[2];
                startTime = r[0];


                if (!flg)
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
        private static bool CanArrive(int fromX, int fromY, int toX, int toY, int startTime, int endTime)
        {
            var difTime = endTime - startTime;
            var difX = Math.Abs(toX - fromX);
            var difY = Math.Abs(toY - fromY);
            if (difTime < difX + difY)
            {
                return false;
            }

            if (difTime == difX + difY)
            {
                return true;
            }

            if (difTime % 2 == 1 && (difX + difY) % 2 == 1 ||
                difTime % 2 == 0 && (difX + difY) % 2 == 0)
            {
                return true;
            }

            return false;
        }
    }
}