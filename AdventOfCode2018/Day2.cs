using System;
using System.Collections;
using System.Collections.Generic;
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

        public string SolvePart2()
        {
            string[] boxIds = ReadFile();
            int stringLength = boxIds[0].Length;
            int currentPosition = 0;

            // Hashset - remove the first letter from all 250, one by one, look for duplicate - if you find it then great, if not add
            while (currentPosition < stringLength)
            {
                // Reinitialise the hashset each go around the loop
                HashSet<string> strippedStrings = new HashSet<string>();
                foreach (string boxId in boxIds)
                {
                    // Remove the current letter by getting two substrings then concatenating
                    string strippedString = boxId.Remove(currentPosition) + boxId.Substring(currentPosition + 1); 

                    // See if it's in the set already
                    if (strippedStrings.Contains(strippedString))
                    {
                        // If it is, that's the answer
                        return strippedString;
                    }
                    // If not, add it to the set for future matching
                    strippedStrings.Add(strippedString);
                }
                currentPosition++;
            }

            return "";
        }

        public virtual string[] ReadFile()
        {
            return File.ReadAllLines(@"C:\Users\Luke\source\repos\AdventOfCode2018\AdventOfCode2018\day2input.txt");
        }
        
    }
}
