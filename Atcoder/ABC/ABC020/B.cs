using System;

namespace Atcoder.ABC.ABC020
{
    public class B : AtcoderBase
    {
        public override void Run()
        {
            var AB = Console.ReadLine().Split();
            var ret = AB[0] + AB[1];
            Console.WriteLine(int.Parse(ret) * 2);
        }
    }
}