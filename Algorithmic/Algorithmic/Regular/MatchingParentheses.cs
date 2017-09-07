using System.Collections.Generic;

namespace Algorithmic.Regular
{
    public class MatchingParentheses
    {
        const char LeftParenthesis = '(';
        const char RightParenthesis = ')';

        public bool IsBalancedWithStack(string str)
        {

            if (str.Length <= 1 || str.Equals(null))
                return false;

            var items = new Stack<int>(str.Length);
            int errorAt = -1;
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i].Equals(LeftParenthesis))
                    items.Push(i);
                else if (str[i].Equals(RightParenthesis))
                {
                    if (items.Count == 0)
                    {
                        errorAt = i + 1;
                        return false;
                    }
                    items.Pop();
                }
            }
            if (items.Count > 0)
            {
                errorAt = items.Peek() + 1;
                return false;
            }
            return true;
        }


        public bool IsBalancedWithoutStack(string str)
        {

            int count = 0;

            if (str.Length <= 1)
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals('('))
                    count++;
                else if (str[i].Equals(')'))
                {
                    count--;
                    if (count < 0)
                        return false;
                }
            }

            return (count == 0);
        }

        public bool CheckParentheses(string str)
        {
            if (str.Length <= 1)
                return false;

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case '(':
                        count++;
                        break;

                    case ')':
                        count--;
                        if (count < 0)
                            return false;
                        break;
                }
            }

            return (count == 0);

        }

        // call from main
        //string[] arrSample = new string[] { " ", "", "(", "()))))))", "(()((fff))())", "(()", "((((()))))", "(()(((())))())", "(()(((())))()", "()()()()()()()()()()()()" };



        //    for (int i = 0; i<arrSample.Length; i++)
        //{
        //    if (isBalancedWithStack(arrSample[i]))
        //    {
        //        Console.WriteLine("{0} is True", arrSample[i]);
        //    }
        //    else
        //    {
        //        Console.WriteLine("{0} is False", arrSample[i]);
        //    }

        //    if (isBalancedWithoutStack(arrSample[i]))
        //    {
        //        Console.WriteLine("{0} is True", arrSample[i]);
        //    }
        //    else
        //    {
        //        Console.WriteLine("{0} is False", arrSample[i]);
        //    }

        //    if (checkParentheses(arrSample[i]))
        //    {
        //        Console.WriteLine("{0} is True", arrSample[i]);
        //    }
        //    else
        //    {
        //        Console.WriteLine("{0} is False", arrSample[i]);
        //    }

        //    Console.WriteLine();
        //}
    }
}
