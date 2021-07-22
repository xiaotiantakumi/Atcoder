using System;
using System.Collections.Generic;
using System.Linq;
using CoderCommon;

namespace Atcoder.ABC043
{
    public class B : CoderBase
    {
        public override void Run()
        {
            var r = Console.ReadLine();
            LinkedList<char> ret = new LinkedList<char>();
            foreach (var s in r)
            {
                switch (s)
                {
                    case '0':
                        ret.AddLast('0');
                        break;
                    case '1':
                        ret.AddLast('1');
                        break;
                    case 'B':
                        if (ret.Any())
                        {
                            ret.RemoveLast();
                        }
                        break;

                }
            }
            Console.WriteLine(new string(ret.ToArray()));

        }
    }
}