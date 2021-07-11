using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Atcoder
{

    class Program
    {
        private const long COMDIV = 1000000007;

        static void Main(string[] args)
        {
            var basePath = @"C:\Users\xiaot\source\repos\Atcoder\Atcoder\典型90";
            var path = Path.Combine(basePath,"1.cs");
            if (File.Exists(path))
            {
                
                for (int i = 10; i <= 90; i++)
                {
                    var fileName = i.ToString() + ".cs";
                    var filePath = Path.Combine(basePath, fileName);
                    if (!File.Exists(filePath)) continue;
                    var rawContent = File.ReadAllLines(filePath);
                    for (var index = 0; index < rawContent.Length; index++)
                    {
                        rawContent[index] = rawContent[index].Replace("No6", "No" + i.ToString());
                    }

                    var s = File.OpenWrite(filePath);
                    var streamWriter = new StreamWriter(s);
                    streamWriter.WriteLine(string.Join("\r\n", rawContent));
                    streamWriter.Flush();
                }
            }
        }
    }
}