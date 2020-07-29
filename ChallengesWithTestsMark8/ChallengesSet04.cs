using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int answer = 0;
            foreach(var num in numbers)
            {
                if(num % 2 == 0)
                {
                    answer += num;
                }
                else
                {
                    answer -= num;
                }
            }
            return answer;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string shortest = str1;
            if(shortest.Length > str2.Length)
            {
                shortest = str2;
            }
            if (shortest.Length > str3.Length)
            {
                shortest = str3;
            }
            if (shortest.Length > str4.Length)
            {
                shortest = str4;
            }
            return shortest.Length;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int shortest = number1;
            if ( shortest > number2 )
            {
                shortest = number2;
            }
            if (shortest > number3)
            {
                shortest = number3;
            }
            if (shortest > number4)
            {
                shortest = number4;
            }
            return shortest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            Console.WriteLine(biz);
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 <= sideLength3 || sideLength1 + sideLength3  <= sideLength2 ||
                             sideLength2 + sideLength3 <= sideLength1)
                return true;
            else
                return false;
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
