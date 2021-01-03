using System;

namespace Atcoder.ABC.ABC187
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var AB = Console.ReadLine().Split();
            int A = 0;
            int B = 0;
            foreach (var a in AB[0])
            {
                A += int.Parse(a.ToString());
            }
            foreach (var b in AB[1])
            {
                B += int.Parse(b.ToString());
            }

            Console.WriteLine(Math.Max(A, B));
        }
    }
}