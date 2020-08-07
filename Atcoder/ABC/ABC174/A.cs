using System;

namespace Atcoder.ABC.ABC174
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var X = int.Parse(Console.ReadLine());
            if (X >= 30)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}