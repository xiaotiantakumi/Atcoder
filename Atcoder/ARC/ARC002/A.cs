using System;

namespace Atcoder.ARC.ARC002
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var y = int.Parse(Console.ReadLine());
            if (y % 400 == 0)
            {
                Console.WriteLine("YES");
            }
            else if (y % 100 == 0)
            {
                Console.WriteLine("NO");
            }
            else if (y % 4 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}