using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Console = System.Console;

namespace Atcoder
{
    class Program
    {

        static void Main(string[] args)
        {
            
        }
        private static readonly Func<string> Read = () => Console.ReadLine();
        private static readonly Func<string[]> ReadStringArray = () => Console.ReadLine().Split();
        private static readonly Func<int> ReadInt = () => int.Parse(Console.ReadLine());
        private static readonly Func<long> ReadLong = () => long.Parse(Console.ReadLine());
        private static readonly Func<int[]> ReadIntArray = () => Console.ReadLine().Split().Select(int.Parse).ToArray();
        private static readonly Func<long[]> ReadLongArray = () => Console.ReadLine().Split().Select(long.Parse).ToArray();
        private static readonly Action<string> Cw = str => Console.WriteLine(str);
    }
}