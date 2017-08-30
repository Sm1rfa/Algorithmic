namespace Algorithmic.Regular
{
    public class FibonacciSeries
    {
        // source https://www.dotnetperls.com/fibonacci
        public int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
