using System;

namespace Atcoder.ABC043
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var r = int.Parse(Console.ReadLine());
            int ret = 0;
            for (int i = 0; i < r; i++)
            {
                ret += i + 1;
            }
            Console.WriteLine(ret);
        }
    }
}