namespace Algorithmic.Regular
{
    public class ReverseString
    {
        public static string Reverse(string x)
        {
            string result = "";
            for (int i = x.Length - 1; i >= 0; i--)
                result += x[i];
            return result;
        }
    }
}
