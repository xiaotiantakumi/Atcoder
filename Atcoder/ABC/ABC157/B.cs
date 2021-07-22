using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC157
{
    public class B : CoderBase
    {
        public override void Run()
        {
            List<int[]> rList = new List<int[]>();
            rList.Add(ReadIntArray());
            rList.Add(ReadIntArray());
            rList.Add(ReadIntArray());
            var N = ReadInt();
            for (int i = 0; i < N; i++)
            {
                var hole = ReadInt();
                for (var j = 0; j < 3; j++)
                {
                    for (var k = 0; k < 3; k++)
                    {
                        if (rList[j][k] == hole)
                        {
                            rList[j][k] = -1;
                        }
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (rList[i].All(x => x == -1))
                {
                    Console.WriteLine("Yes");
                    return;
                }

                if (rList[0][i] == -1 && rList[1][i] == -1 && rList[2][i] == -1)
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }

            if (rList[0][0] == -1 && rList[1][1] == -1 && rList[2][2] == -1 ||
                rList[0][2] == -1 && rList[1][1] == -1 && rList[2][0] == -1)
            {
                Console.WriteLine("Yes");
                return;
            }

            Console.WriteLine("No");
        }
    }
}