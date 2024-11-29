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
            //test.solution("aukks", "wbqd", 5);
            test.solution(new int[] { 2, 6, 8, 14 });

            Console.ReadKey();
        }
    }
}
