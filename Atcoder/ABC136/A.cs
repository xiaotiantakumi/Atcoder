using System;
using System.Linq;

namespace Atcoder.ABC136
{
    public class A : IAtcoder
    {
        public void Run()
        {
            var inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (inputs[0] <= inputs[1] + inputs[2])
            {
                Console.WriteLine(inputs[2] - (inputs[0] - inputs[1]));
            }
            else
            {
                Console.WriteLine(0);

            }
        }
    }
}