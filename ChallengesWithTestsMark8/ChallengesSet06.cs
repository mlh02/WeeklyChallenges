using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            int counter = 0;
            for(int i = 0; i < words.ToArray().Length; i++)
            {
                string currWord = words.ToArray()[i];
                
                    if (words.Contains(currWord.ToLower()))
                    {
                        counter++;
                    } 
                              
            }
            if (counter == 0 || words.Contains(null)){
                return false;
            }
            return true;
        }

        public bool IsPrimeNumber(int num)
        {
            throw new NotImplementedException();
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}
