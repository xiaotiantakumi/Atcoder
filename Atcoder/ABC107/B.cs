using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC107
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var H = input[0];
            var W = input[1];
            List<List<char>> row = new List<List<char>>();
            for (int i = 0; i < H; i++)
            {
                var tmp = Console.ReadLine();
                if (tmp.Any(x => x == '#'))
                {
                    row.Add(tmp.ToList());
                }
            }

            for (int i = W - 1; i >= 0; i--)
            {
                bool delFlg = true;
                for (int j = 0; j < row.Count; j++)
                {
                    if (row[j][i] == '#')
                    {
                        delFlg = false;
                        break;
                    }
                }

                if (delFlg)
                {
                    for (int j = 0; j < row.Count; j++)
                    {
                        row[j].RemoveAt(i);
                    }
                }
            }

            foreach (var r in row)
            {
                Console.WriteLine(new string(r.ToArray()));
            }
        }
    }
}