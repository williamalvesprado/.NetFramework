using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace System.IO.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("the quik brown fox jumps over lazy dog");
            File.AppendAllText(@"d:\1.txt", sb.ToString());

            string[] values = { "Line 1", "Line 2", "Line 3" };
            File.AppendAllLines(@"d:\2.txt", values);

            /* 
            
            File.Copy(@"d:\1.txt", @"d:\3.txt");

            File.Encrypt(@"d:\3.txt");

            File.Decrypt(@"d:\3.txt");

            */
        }
    }
}
