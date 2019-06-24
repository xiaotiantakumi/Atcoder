using Atcoder;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atcoder
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = first[0];
            List<int> tmpList = new List<int>();
            var L = first[1];            
            for (int i = 0; i < N; i++)
            {
                tmpList.Add(L + i);
            }
            var except = tmpList.Select(x => Math.Abs(x)).Min();
            int result = 0;
            foreach (var item in tmpList)
            {
                if (item == except || item == -except)
                {
                    continue;
                }
                result += item;
            }
            Console.Write(result);
        }
        //static void Main(string[] args)
        //{
        //    var temp = new Atcoder.ABC129.B();
        //    temp.Run();
        //}

    }
}