using System;
using System.Collections;
using System.IO;

namespace AdventOfCode2018
{
    public class Day2
    {
        
        public int SolvePart1()
        {
            int sumDoubles = 0;
            int sumTriples = 0;

            foreach (string boxId in ReadFile()) {
                Hashtable letters = new Hashtable();
                
                foreach (char character in boxId)
                {
                    if (letters.Contains(character))
                    {
                        letters[character] = (int) letters[character] + 1;
                    }
                    else
                    {
                        letters.Add(character, 1);
                    }
                }

                if (letters.ContainsValue(2))
                {
                    sumDoubles++;
                }
                if (letters.ContainsValue(3))
                {
                    sumTriples++;
                }
            }

            return sumDoubles * sumTriples;
        }

        //public int SolvePart2()
        //{
            
        //}

        public virtual string[] ReadFile()
        {
            return File.ReadAllLines(@"C:\Users\Luke\source\repos\AdventOfCode2018\AdventOfCode2018\day2input.txt");
        }
        
    }
}
