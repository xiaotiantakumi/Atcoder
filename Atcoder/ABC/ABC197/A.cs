using System;

namespace Atcoder.ABC.ABC197
{
    public class A : AtcoderBase
    {
        public override  void Run()
        {
            var str = Console.ReadLine();
            var ret = str[1].ToString() + str[2].ToString() + str[0].ToString();
            Console.WriteLine(ret);
        }
    }
}