using System;

namespace Atcoder.ABC.ABC192
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var X = int.Parse(Console.ReadLine());
            Console.WriteLine(100 - (X % 100));
        }
    }
}