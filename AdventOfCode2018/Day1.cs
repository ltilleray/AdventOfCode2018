using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode2018
{
    public class Day1
    {

        private HashSet<int> frequencies;
        private bool matchFound;

        public int SolvePart1()
        {
            var result = 0;
            foreach (string line in ReadFile()) {
                result = AddNumbers(result, Int32.Parse(line));
            }
            return result;
        }

        public int SolvePart2()
        {
            // Prepare a set to hold all known frequencies
            var currentFrequency = 0;
            frequencies = new HashSet<int>
            {
                currentFrequency
            };

            matchFound = false;
            while (matchFound == false)
            {
                currentFrequency = IterateOverFrequencies(currentFrequency);
            }

            return currentFrequency;
        }

        public int AddNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public string[] ReadFile()
        {
            return File.ReadAllLines(@"C:\Users\Luke\source\repos\AdventOfCode2018\AdventOfCode2018\day1input.txt");
        }

        public int IterateOverFrequencies(int currentFrequency)
        {
            // Iterate through the list, adding to the set every time
            foreach (string line in ReadFile())
            {
                currentFrequency = AddNumbers(currentFrequency, Int32.Parse(line));

                // If we have a duplicate - this is the answer!
                if (frequencies.Contains(currentFrequency))
                {
                    matchFound = true;
                    return currentFrequency;
                }
                frequencies.Add(currentFrequency);
            }

            // if no match found, return current frequency as the next iteration will start from here
            return currentFrequency;
        }
    }
}
