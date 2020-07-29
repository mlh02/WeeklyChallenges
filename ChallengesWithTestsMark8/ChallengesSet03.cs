using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            int falseCounter = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                if(vals[i] == false)
                {
                    falseCounter++;
                }
            }
            if (falseCounter == 0)
            {
                return false;
            }
            return true;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            List<int> asList = numbers.ToList();
            int oddSum = 0;
            int newM = 0;
            foreach(var m in asList)
            {
                if(m < 0)
                {
                    newM = m * -1;
                }
                else
                {
                    newM = m;
                }
                if (newM % 2 == 1)
                {
                    oddSum += m;
                }
            }
            if(oddSum % 2 != 0)
            {
                return true;
            }
           
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            string low = "asdfghjklzxcvbnmqwertyuiop";
            int lowCounter = 0;
            string high = "ASDFGHJKLZXCVBNMQWERTYUIOP";
            int highCounter = 0;
            string numb = "1234567890";
            int numCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                var currLet = password[i];
                if (low.Contains(currLet))
                {
                    lowCounter = 1;
                }
                if (high.Contains(currLet))
                {
                    highCounter = 1;
                }
                if (numb.Contains(currLet))
                {
                    numCounter = 1;
                }
            }
            var answer = lowCounter + highCounter + numCounter;
            if (answer == 3)
            {
                return true;
            }
            return false;
        } 

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0 || dividend == 0)
            {
                return 0;
            }
            return dividend / divisor;

        }

        public int LastMinusFirst(int[] nums)
        {
            int lastNum = nums[nums.Length - 1];
            int firstNum = nums[0];
            return lastNum - firstNum;
        }
        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50];
            for(int i = 1; i < 101; i = + 2)
            {
                odds.Append(i);
            }
            return odds;

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words.Length == 0)
            {
                Console.WriteLine(new string[0]);
            }
            string letters = "qwertyuiopasdfghjklzxcvbnm";
            string[] final = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                char[] array = words[i].ToCharArray();
                for (int j = 0; j < array.Length; j++)
                {
                    char let = array[j];
                    if (letters.IndexOf(let) > -1)
                    {
                        array[j] = char.ToUpper(let);
                    }
                    else
                    {
                        array[j] = let;
                    }
                }
                string result = new string(array);
                words[i] = result;

            }
            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
