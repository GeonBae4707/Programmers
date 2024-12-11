using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Test
    {
        static void Main()
        {
            Solution test = new Solution();
            //test.solution("(({)})");
            test.solution("[](){}");

            Console.ReadKey();
        }
    }
}
