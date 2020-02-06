using System;
using System.Linq;

namespace Atcoder
{
    internal interface IAtcoder
    {
        void Run();
    }
    public class AtcoderBase : IAtcoder
    {
        public virtual void Run()
        {
        }
        public static readonly Func<string> Read = () => Console.ReadLine();
        public static readonly Func<string[]> ReadStringArray = () => Console.ReadLine().Split();
        public static readonly Func<int[]> ReadIntArray = () => Console.ReadLine().Split().Select(int.Parse).ToArray();
        public static readonly Func<long[]> ReadLongArray = () => Console.ReadLine().Split().Select(long.Parse).ToArray();
    }
}