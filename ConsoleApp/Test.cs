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
            test.solution(new string[] { "banana", "apple", "rice", "pork", "pot" }, new int[] { 3, 2, 2, 2, 1 }, new string[] { "chicken", "apple", "apple", "banana", "rice", "apple", "pork", "banana", "pork", "rice", "pot", "banana", "apple", "banana" });

            Console.ReadKey();
        }
    }
}
