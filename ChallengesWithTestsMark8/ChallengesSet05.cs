using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if ((numbers == null) || (numbers.Length == 0))
                return false;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }


        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null)
            {
                return "";
            }

            string final = "";
            foreach (var word in words)
            {
                if (word.Trim() != "")
                {
                    final += word.Trim() + " ";
                }
            }
            if (final.Length == 0)
            {
                return "";
            }
            return final.Trim() + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> everyFourth = new List<double>();
            double[] answer = new double[] { };
            if (elements == null)
            {
                return answer;
            }


            for (int i = 3; i < elements.Count; i += 4)
            {
                everyFourth.Add(elements[i]);
            }
            if (elements == null)
            {
                return null;
            }

            return everyFourth.ToArray();

        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}