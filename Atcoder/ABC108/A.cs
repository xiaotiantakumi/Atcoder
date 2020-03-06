using System;
using System.Linq;
namespace Atcoder.ABC108
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var K = int.Parse(Console.ReadLine());
            var A = K / 2;
            int B;
            if (K % 2 == 0)
            {
                B = A;
            }
            else
            {
                B = A + 1;
            }
            Console.WriteLine(A * B);
        }
    }
}