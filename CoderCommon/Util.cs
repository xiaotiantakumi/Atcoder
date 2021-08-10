using System;
using System.Collections.Generic;
using System.Linq;

namespace CoderCommon
{
    public static class Util
    {
        // 最小公倍数
        public static long Lcm(long a, long b)
        {
            return a * (b / Gcd(a, b));
        }
        public static long Gcd(long a, long b)
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

        public static List<T[]> AllPermutation<T>(params T[] array) where T : IComparable
        {
            var a = new List<T>(array).ToArray();
            var res = new List<T[]>();
            res.Add(new List<T>(a).ToArray());
            var n = a.Length;
            var next = true;
            while (next)
            {
                next = false;

                // 1
                int i;
                for (i = n - 2; i >= 0; i--)
                {
                    if (a[i].CompareTo(a[i + 1]) < 0) break;
                }
                // 2
                if (i < 0) break;

                // 3
                var j = n;
                do
                {
                    j--;
                } while (a[i].CompareTo(a[j]) > 0);

                if (a[i].CompareTo(a[j]) < 0)
                {
                    // 4
                    var tmp = a[i];
                    a[i] = a[j];
                    a[j] = tmp;
                    Array.Reverse(a, i + 1, n - i - 1);
                    res.Add(new List<T>(a).ToArray());
                    next = true;
                }
            }
            return res;
        }

        public static T Median<T>(this IList<T> items)
        {
            if (items == null || items.Count <= 0) return default(T);
            List<T> sortedItems = new List<T>(items);
            sortedItems.Sort();
            if (sortedItems.Count % 2 == 0)
            {
                return sortedItems[sortedItems.Count / 2];
            }

            return default(T);
        }

        static IEnumerable<long> GetPrimes(long n)
        {
            while ((n & 1) == 0)
            {
                n >>= 1;
                yield return 2;
            }
            for (long i = 3; i * i <= n; i += 2)
            {
                while (n % i == 0)
                {
                    n /= i;
                    yield return i;
                }
            }
            if (n != 1) yield return n;
        }

        /// <summary>
        /// 座標圧縮
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="raw"></param>
        /// <returns></returns>
        static private List<int> CoordinateCompression<T>(List<T> raw) where T : struct
        {
            var values = raw.Distinct().OrderBy(x => x).ToList();
            List<int> result = new List<int>();
            foreach (var t in raw)
            {
                var index = values.BinarySearch(t);
                result.Add(values.BinarySearch(t));
            }
            return result;
        }
    }
}
