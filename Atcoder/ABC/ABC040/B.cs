using System;

namespace Atcoder.ABC.ABC040
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var ret = int.MaxValue;
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    var mple = i * j;
                    if (mple > N)
                    {
                        break;
                    }

                    var tmp = Math.Abs(i - j) + (N - mple);
                    ret = Math.Min(ret, tmp);
                }
            }
            Console.WriteLine(ret);
        }
    }
}