using System;

namespace Atcoder.ABC081
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var r = Console.ReadLine();
            int ret = 0;
            foreach (var c in r)
            {
                ret += int.Parse(c.ToString());
            }
            Console.WriteLine(ret);
        }
    }
}