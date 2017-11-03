using System;
using System.Globalization;
using System.Linq;

namespace Algorithmic.Basic
{
    public class StringOperations
    {
        public static string Reverse(string x)
        {
            string result = "";
            for (int i = x.Length - 1; i >= 0; i--)
                result += x[i];
            return result;
        }

        public void DefineIfStartsWithUpperCase(string str)
        {
            var firstChar = str.Remove(1, str.Length - 1);
            Console.WriteLine(firstChar.StartsWith(firstChar.ToUpper())
                ? $"String {str} starts with capital letter {firstChar}"
                : $"String {str} starts with lower letter {firstChar}");
        }
    }
}
