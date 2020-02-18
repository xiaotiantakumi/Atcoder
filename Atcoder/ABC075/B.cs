using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC075
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var H = r[0];
            var W = r[1];
            List<string> bord = new List<string>();
            for (int i = 0; i < H; i++)
            {
                bord.Add(Console.ReadLine());
            }

            int[] dx = new int[8] { 1, 1, 1, 0, 0, -1, -1, -1 };
            int[] dy = new int[8] { 1, 0, -1, 1, -1, 1, 0, -1 };

            List<string> ret = new List<string>();
            for (int i = 0; i < H; i++)
            {
                string s = string.Empty;
                for (int j = 0; j < W; j++)
                {
                    int num = 0;
                    if (bord[i][j] == '#')
                    {
                        s += '#';
                        continue;
                    }

                    for (int k = 0; k < 8; k++)
                    {
                        int difx = i + dy[k];
                        int dify = j + dx[k];
                        if (difx < 0 || W <= difx || dify < 0 || H <= dify)
                        {
                            continue;
                        }

                        if (bord[difx][dify] == '#')
                        {
                            num++;
                        }
                    }

                    s += num.ToString();
                }
                Console.WriteLine(s);
            }
        }

        public void OtherOne()
        {
            var HW = ReadIntArray();
            var H = HW[0];
            var W = HW[1];

            List<string> lineInfo = new List<string>();
            for (int i = 0; i < HW[0]; i++)
            {
                lineInfo.Add(Read());
            }
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    if (lineInfo[i][j] == '#')
                    {

                    }
                }
            }
        }
    }
}