using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC.ABC211
{
    public class B : CoderBase
    {
        public override void Run()
        {
            List<string> list = new List<string>()
            {
                "H" , "2B" , "3B" , "HR"
            };
            List<string> inputs = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                var r = Console.ReadLine();
                inputs.Add(r);
            }

            Console.WriteLine(list.Except(inputs).ToList().Count == 0 ? "Yes" : "No");
        }
    }
}