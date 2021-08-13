using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC197
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var HWXY = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var H = HWXY[0];
            var W = HWXY[1];
            var X = HWXY[2] - 1;
            var Y = HWXY[3] - 1;
            char[,] map = new char[H, W];
            for (int i = 0; i < H; i++)
            {
                var s = Console.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    map[i, j] = s[j];
                }
            }

            long ret = 1;
            int start = -1;
            while (true)
            {
                if (X + start < 0 || map[X + start, Y] == '#')
                {
                    break;
                }
                ret++;
                start--;
            }
            start = 1;
            while (true)
            {
                if (X + start == H || map[X + start, Y] == '#')
                {
                    break;
                }
                ret++;
                start++;
            }
            start = -1;
            while (true)
            {
                if (Y + start < 0 || map[X, Y + start] == '#')
                {
                    break;
                }
                ret++;
                start--;
            }
            start = 1;
            while (true)
            {
                if (Y + start == W || map[X, Y + start] == '#')
                {
                    break;
                }
                ret++;
                start++;
            }

            Console.WriteLine(ret);
        }
    }
}