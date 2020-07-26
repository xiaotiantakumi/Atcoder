using System;
using System.Collections.Generic;

namespace Atcoder.ABC.ABC006
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var n = int.Parse(Console.ReadLine());
            var tori = new Torib();
            Console.WriteLine(tori.F(n));
        }

        class Torib
        {

            Dictionary<int, decimal> dic = new Dictionary<int, decimal>();
            public Torib()
            {
            }

            public decimal F(int val)
            {

                if (dic.ContainsKey(val))
                {
                    return dic[val];
                }
                else if (val == 0 || val == 1)
                {
                    dic[val] = 0;
                    return 0;
                }
                else if (val == 2)
                {
                    dic[val] = 1;
                    return 1;
                }
                else
                {
                    dic[val] = (F(val - 1)  + F(val - 2)  + F(val - 3)) % 10007;
                    return dic[val];
                }
            }
        }
    }
}