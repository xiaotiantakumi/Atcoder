using System;

namespace Atcoder.ABC.ABC178
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine(x == 0 ? 1 : 0);
        }
    }
}