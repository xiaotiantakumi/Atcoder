using System;
using System.Linq;

namespace Atcoder.MyTest
{
    public class A20200123 : IAtcoder
    {
        public void Run()
        {
            var tmp = Combination(3);
        }

        private static string Combination(int val)
        {
            if (val == 0)
            {
                return string.Empty;
            }
            string ret = string.Empty;
            return val.ToString() + Combination(val - 1);

        }
    }
}