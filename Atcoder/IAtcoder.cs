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
    }
}