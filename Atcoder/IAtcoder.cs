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

        public static readonly Func<string> Read = () => Console.ReadLine();
        public static readonly Func<string[]> ReadStringArray = () => Console.ReadLine().Split();
        public static readonly Func<int[]> ReadIntArray = () => Console.ReadLine().Split().Select(int.Parse).ToArray();
        public static readonly Func<long[]> ReadLongArray = () => Console.ReadLine().Split().Select(long.Parse).ToArray();
        public static readonly Action<string> Cwl = str => Console.WriteLine(str);
    }
}