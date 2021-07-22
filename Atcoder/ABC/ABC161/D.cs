using System;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC161
{
    public class D : CoderBase
    {
        public override void Run()
        {
            var K = int.Parse(Console.ReadLine());
            long ret = 1;
            for (int i = 1; i <= K; i++)
            {
                if (i <= 10)
                {
                    ret = i;
                    continue;
                }

                var tmp = ret;
                var current = ret.ToString().ToCharArray();
                int keta = current.Length;
                while (true)
                {
                    if (keta == 0)
                    {
                        ret = long.Parse((1 * Math.Pow(10, current.Length)).ToString());
                        break;
                    }
                    var before = int.Parse(current[keta - 1].ToString());
                    if (keta == 1 && before != 9)
                    {
                        current[keta - 1] = (before + 1).ToString().ToCharArray()[0];
                        current[keta] = (before).ToString().ToCharArray()[0];
                        ret = long.Parse(new string(current));
                        break;
                    }
                    var after = int.Parse(current[keta - 2].ToString());
                    if (before - after < 1)
                    {
                        if (ret.ToString().All(x => x == '9'))
                        {
                            ret = long.Parse((1 * Math.Pow(10, current.Length)).ToString());
                            break;
                        }
                        current[keta - 1] = (before + 1).ToString().ToCharArray()[0];
                        ret = long.Parse(new string(current));
                        break;
                    }
                    keta--;
                }
            }

            Console.WriteLine(ret);
        }
    }
}