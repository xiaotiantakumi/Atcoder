using System;

namespace Atcoder.ABC151
{
    public class A : AtcoderBase
    {
        public override void Run()
        {
            var array = "abcdefghijklmnopqrstuvwxyz";
            var r = Console.ReadLine();
            var nowPos = array.IndexOf(r);
            Console.WriteLine(array[nowPos + 1]);
        }
    }
}