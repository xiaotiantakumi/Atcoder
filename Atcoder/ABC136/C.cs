using System;
using System.Linq;

namespace Atcoder.ABC136
{
    public class C : IAtcoder
    {
        public void Run()
        {
            var N = int.Parse(Console.ReadLine());
            var inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var ret = 0;
            for (int i = inputs.Length - 1; i >= 1; i--)
            {
                if (inputs[i - 1] - inputs[i] == 1)
                {
                    inputs[i - 1]--;
                }
                else if (inputs[i - 1] - inputs[i] > 1)
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}