using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC096
{
    public class C : AtcoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var H = r[0];
            var W = r[1];
            List<string> lineInfo = new List<string>();
            for (int i = 0; i < H; i++)
            {
                lineInfo.Add(Console.ReadLine());
            }

            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    if (lineInfo[i][j] == '#')
                    {
                        if (!Check(lineInfo, i, j))
                        {
                            Console.WriteLine("No");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine("Yes");
        }
        public static bool Check(List<string> info, int h, int w)
        {
            return Left(info, h, w) || Right(info, h, w) || Up(info, h, w) || Down(info, h, w);
        }
        public static bool Left(List<string> info, int h, int w)
        {
            if (w == 0)
            {
                return false;
            }

            if (info[h][w] == info[h][w - 1])
            {
                return true;
            }
            return false;
        }
        public static bool Right(List<string> info, int h, int w)
        {
            if (w == info[0].Length - 1)
            {
                return false;
            }

            if (info[h][w] == info[h][w + 1])
            {
                return true;
            }
            return false;
        }
        public static bool Up(List<string> info, int h, int w)
        {
            if (h == 0)
            {
                return false;
            }

            if (info[h][w] == info[h - 1][w])
            {
                return true;
            }
            return false;
        }
        public static bool Down(List<string> info, int h, int w)
        {
            if (h == info.Count())
            {
                return false;
            }

            if (info[h][w] == info[h + 1][w])
            {
                return true;
            }
            return false;
        }
    }
}