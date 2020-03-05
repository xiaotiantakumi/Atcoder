using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC075
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var HW = ReadIntArray();
            int[] dx = new int[] { 0, 1, 1, 1, 0, -1, -1, -1 };
            int[] dy = new int[] { -1, -1, 0, 1, 1, 1, 0, -1 };
            List<char[]> graph = new List<char[]>();
            for (int i = 0; i < HW[0]; i++)
            {
                graph.Add(Read().ToCharArray());
            }

            for (int height = 0; height < HW[0]; height++)
            {
                for (int width = 0; width < HW[1]; width++)
                {

                    if (graph[height][width] == '.')
                    {
                        int countBom = 0;
                        for (int i = 0; i < dx.Length; i++)
                        {
                            if (width + dx[i] < 0 ||
                                width + dx[i] >= HW[1] ||
                                height + dy[i] < 0 ||
                                height + dy[i] >= HW[0])
                            {
                                continue;
                            }

                            if (graph[height + dy[i]][width + dx[i]] == '#')
                            {
                                countBom++;
                            }
                        }

                        graph[height][width] = countBom.ToString().ToCharArray()[0];
                    }
                }
            }

            foreach (var row in graph)
            {
                Console.WriteLine(new string(row));
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