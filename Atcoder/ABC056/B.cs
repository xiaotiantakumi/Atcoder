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
            List<Tuple<int, int>> ret = new List<Tuple<int, int>>();
            foreach (var position in positions)
            {
                int tmpRet = 0;
                for (int i = 0; i < M; i++)
                {
                    var distance = Math.Abs(position[0] - checkPos[i][0]) + Math.Abs(position[1] - checkPos[i][1]);
                    ret.Add(new Tuple<int, int>(i, distance));
                }
            }
        }
    }
}