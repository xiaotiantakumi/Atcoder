using System;

namespace Atcoder.ABC090
{
    public class A : IAtcoder
    {
        public void Run()
        {
            string ret = string.Empty;
            ret += Console.ReadLine().ToCharArray()[0];
            ret += Console.ReadLine().ToCharArray()[1];
            ret += Console.ReadLine().ToCharArray()[2];
            Console.WriteLine(ret);
        }
    }
}