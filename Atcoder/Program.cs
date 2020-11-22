using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Atcoder
{

    class Program
    {
        private const long COMDIV = 1000000007;

        static void Main(string[] args)
        {
            
        }

        private static T Max<T>(params T[] array) where T : IComparable
        {
            if (array == null) return default;
            T ret = array[0];
            foreach (var item in array)
            {
                ret = ret.CompareTo(item) > 0 ? ret : item;
            }
            return ret;
        }

        private static T Min<T>(params T[] array) where T : IComparable
        {
            if (array == null) return default;
            T ret = array[0];
            foreach (var item in array)
            {
                ret = ret.CompareTo(item) < 0 ? ret : item;
            }
            return ret;
        }

        private static void Swap<T>(ref T a, ref T b) where T : struct
        {
            T tmp = a;
            a = b;
            b = tmp;
        }

    }
}