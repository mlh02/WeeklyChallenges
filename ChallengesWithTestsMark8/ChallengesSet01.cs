﻿using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
           return num1 == num2;
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
            int answer = number1 + number2;
            return answer;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            return number1 > number2 ? number2 : number1;
            
        }

        public long Multiply(long factor1, long factor2)
        {
            var answer = factor1 * factor2;
            return answer;
        }

        public string GetGreeting(string nameOfPerson)
        {
            return $"Hello {nameOfPerson}";
        }

        public string GetHey()
        {
            return "Get Hey";
        }
    }
}
