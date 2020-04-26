using System;
using System.Linq;

namespace Atcoder.ABC060
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var ABC = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var A = ABC[0];
            var B = ABC[1];
            var C = ABC[2];
            Calc(A,B,C);
        }
        private static int count = 0;
        private static int sum = 0;
        private static void Calc(int A,int B,int C)
        {
            if (count > 1000)
            {
                Console.WriteLine("NO");
                return;
            }

            count++;
            sum += A;
            if (sum % B == C)
            {
                Console.WriteLine("YES");
                return;
            }
            Calc(A,B,C);
        }
    }
}