using System;

namespace Atcoder.OtherRatedCon.三井住友信託銀行プログラミングコンテスト2019
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var val = (int)Math.Truncate(N / 1.08);
            for (int i = val - 1; i <= val + 1; i++)
            {
                if ((int)Math.Truncate(i * 1.08) == N)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine(@":(");
        }
    }
}