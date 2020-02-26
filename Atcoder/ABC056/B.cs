using System;
using System.Collections.Generic;

namespace Atcoder.ABC056
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var r = ReadIntArray();
            var N = r[0];
            var M = r[1];
            List<int[]> positions = new List<int[]>();
            for (int i = 0; i < N; i++)
            {
                positions.Add(ReadIntArray());
            }
            List<int[]> checkPos = new List<int[]>();
            for (int i = 0; i < M; i++)
            {
                checkPos.Add(ReadIntArray());
            }

            int[] retList = new int[N];
            for (int i = 0; i < N; i++)
            {
                double distance = double.MaxValue;
                for (int j = 0; j < M; j++)
                {
                    var tmpDistance = Math.Abs(positions[i][0] - checkPos[j][0]) +
                                      Math.Abs(positions[i][1] - checkPos[j][1]);
                    if (tmpDistance < distance)
                    {
                        distance = Math.Min(distance, tmpDistance);
                        retList[i] = j + 1;
                    }
                }
            }

            foreach (var item in retList)
            {
                Console.WriteLine(item);
            }
        }
    }
}