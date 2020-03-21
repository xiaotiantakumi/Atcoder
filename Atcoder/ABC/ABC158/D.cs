using System;
using System.Collections.Generic;
using System.Linq;

namespace Atcoder.ABC158
{
    public class D : AtcoderBase
    {
        public override void Run()
        {
            LinkedList<char> s = new LinkedList<char>();
            var firstS = Read();
            s.AddLast('1');
            var N = ReadLong();
            bool isReverse = false;
            for (int i = 0; i < N; i++)
            {
                var r = Console.ReadLine().Split();
                if (r.Length == 1)
                {
                    isReverse = !isReverse;
                    continue;
                }

                var putFirst = int.Parse(r[1]) == 1;
                if (putFirst)
                {
                    if (isReverse)
                    {
                        s.AddLast(r[2][0]);
                    }
                    else
                    {
                        s.AddFirst(r[2][0]);
                    }

                }
                else
                {
                    if (isReverse)
                    {
                        s.AddFirst(r[2][0]);
                    }
                    else
                    {
                        s.AddLast(r[2][0]);
                    }
                }
            }

            var ts = new string(s.ToArray());
            ts = ts.Replace("1", firstS);
            var ret = isReverse ? new string(ts.Reverse().ToArray()) : ts;
            Console.WriteLine(ret);
        }
    }
}