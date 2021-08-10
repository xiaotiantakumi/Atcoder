using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace Atcoder
{

    class Program
    {
        private const long COMDIV = 1000000007;

        static void Main()
        {
            SourceExpander.Expander.Expand(ignoreAnyError: false);
            var tmp = CoderCommon.Util.Lcm(15, 20);
            Console.WriteLine(tmp);
        }
        
    }
}