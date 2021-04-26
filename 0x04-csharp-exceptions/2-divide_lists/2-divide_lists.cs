using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> answerList = new List<int>() {};
        for (int i = 0; i < listLength; i++)
        {
            int answer = 0;
            try
            {
                answer = list1[i] / list2[i];
                answerList.Add(answer);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                answerList.Add(answer);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return answerList;
    }
}
