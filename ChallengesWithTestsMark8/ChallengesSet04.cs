using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evens = 0;
            var odds = 0;
            foreach (var x in numbers)
            {
                if (x % 2 == 0)
                {
                    evens += x;
                }
                else if (x % 2 != 0)
                {
                    odds += x;
                }
            }
            return evens - odds;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var one = str1.Length;
            var two = str2.Length;
            var three = str3.Length;
            var four = str4.Length;
            if (one < two && one < three && one < four)
            {
                return one;
            }
            else if (two <= one && two < three && two < four)
            {
                return two;
            }
            else if (three <= one && three <= two && three < four)
            {
                return three;
            }
            else { return four; }
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var one = number1;
            var two = number2;
            var three = number3;
            var four = number4;
            if (one < two && one < three && one < four)
            {
                return one;
            }
            else if (two <= one && two < three && two < four)
            {
                return two;
            }
            else if (three <= one && three <= two && three < four)
            {
                return three;
            }
            else { return four; }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var answer = false;
           
            if (sideLength1 + sideLength2 > sideLength3)
            {
                if (sideLength2 + sideLength3 > sideLength1)
                {
                    if (sideLength1 + sideLength3 > sideLength2)
                    {
                        answer = true;
                    }
                }
            }
            return answer;
        }

        public bool IsStringANumber(string input)
        {
            int a = 0;
            if (input == null)
            {
                return false;
            }
            if (input.Length < 1)
            {
                return false;
            }

            foreach (var n in input)
            {
                if (char.IsDigit(n))
                {
                    a++;
                }
                else if (char.IsLetter(n))
                {
                    a += 0;
                }
                else if (char.IsSymbol(n))
                {
                    a += 0;
                }
                else if (n == '.')
                {
                    a++;
                }
                else if (n == '-')
                {
                    a++;
                }

            }
            if (a == input.Length)
            {
                return true;
            }
            else { return false; }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var count = 0;
            foreach (var o in objs)
            {
                if (o == null)
                {
                    count++;
                }
            }
            if (count > objs.Length / 2)
            {
                return true;
            }
            else { return false; }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var a = new List<double>();
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    a.Add(numbers[i]);
                }
            }
            for (int i = 0; i < a.Count; i++)
            {
                sum += a[i];
            }
            if (a.Count == 0)
            {
                return 0;
            }
            else
            {
                return sum / a.Count;
            }
        }

        public int Factorial(int number)
        {
            int fact = number;
            if (fact < 0)
            {
                throw new ArgumentOutOfRangeException("age", "All factorials must be positive.");
            }
            if (fact == 0)
            {
                fact = 1;
            }
            for (int i = number - 1; i >= 1; i--)
            {

                if (i > 0)
                {
                    i = Math.Abs(i);
                }
                fact *= i;

            }
            return fact;
        }
    }
}
    