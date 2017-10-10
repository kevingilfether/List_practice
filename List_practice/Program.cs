using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting up a list of test scores
            List<int> testScores = new List<int>() { 98, 100, 76, 84, 93 };
            testScores.Add(80);
            testScores.Add(99);

            // populating empty list
            List<int> luckyNumbers = new List<int>();
            luckyNumbers.Add(2);
            luckyNumbers.Add(3);
            luckyNumbers.Add(5);
            luckyNumbers.Add(7);
        }
    }
}
