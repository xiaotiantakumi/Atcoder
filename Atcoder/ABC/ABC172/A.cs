using System;

namespace Atcoder.ABC.ABC172
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var r = int.Parse(Console.ReadLine());
            Console.WriteLine(r + Math.Pow(r, 2) + Math.Pow(r, 3));
        }
    }
}