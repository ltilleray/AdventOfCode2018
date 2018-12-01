using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode2018
{
    class Day1
    {

        public int SolvePart1()
        {
            var result = 0;
            foreach (string line in ReadFile()) {
                result = addNumbers(result, Int32.Parse(line));
            }
            return result;
        }

        public int addNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public string[] ReadFile()
        {
            return File.ReadAllLines(@"C:\Users\Luke\source\repos\AdventOfCode2018\AdventOfCode2018\day1input.txt");
        }
    }
}
