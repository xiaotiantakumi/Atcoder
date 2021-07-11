using System;
using System.Linq;

namespace Atcoder
{
    internal interface IAtcoder
    {
        void Run();
    }
    public abstract class AtcoderBase : IAtcoder
    {
        public abstract void Run();

        protected static readonly Func<string> Read = () => Console.ReadLine();
        protected static readonly Func<string[]> ReadStringArray = () => Console.ReadLine().Split();
        protected static readonly Func<int> ReadInt = () => int.Parse(Console.ReadLine());
        protected static readonly Func<long> ReadLong = () => long.Parse(Console.ReadLine());
        protected static readonly Func<int[]> ReadIntArray = () => Console.ReadLine().Split().Select(int.Parse).ToArray();
        protected static readonly Func<long[]> ReadLongArray = () => Console.ReadLine().Split().Select(long.Parse).ToArray();
        protected static readonly Action<string> Cw = str => Console.WriteLine(str);
        protected const long COMDIV = 1000000007;
        protected static T Max<T>(params T[] array) where T : IComparable
        {
            if (array == null) return default;
            T ret = array[0];
            foreach (var item in array)
            {
                ret = ret.CompareTo(item) > 0 ? ret : item;
            }
            return ret;
        }

        protected static T Min<T>(params T[] array) where T : IComparable
        {
            if (array == null) return default;
            T ret = array[0];
            foreach (var item in array)
            {
                ret = ret.CompareTo(item) < 0 ? ret : item;
            }
            return ret;
        }

        protected static void Swap<T>(ref T a, ref T b) where T : struct
        {
            T tmp = a;
            a = b;
            b = tmp;
        }

        // 最小公倍数
        protected static long Lcm(long a, long b)
        {
            return a * (b / Gcd(a, b));
        }
        protected static long Gcd(long a, long b)
        {
            if (a < b)
                return Gcd(b, a);
            while (b != 0)
            {
                var remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }
}