using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace Algorithmic.Regular
{
    public class ArrayOutput
    {
        // method call
        //static void Main(string[] args)
        //{
        //    int[] arr = new int[] { 1, 2, 3, 4, 5 };
        //    fun1(ref arr);
        //    Console.ReadLine();
        //}

        public void Fun1(ref int[] array)
        {
            for (int i = 0; i < array.Length; i = i + 2)
            {
                array[i] = array[i] + 10;
            }
            Console.WriteLine(string.Join(",", array));
        }

        public void Fun2(int[] array)
        {
            var sum = 0;
            for (var i = 0; i <= array.Length - 1; i++)
            {
                sum = sum + array[i];
            }

            var result = sum / array.Length;
            Console.WriteLine($"Delimer is: {result}");
            Console.Read();
        }

        public double ClosestToZero(double[] ts)
        {
            if (ts == null || ts.Length == 0)
            {
                return 0;
            }

            var nearest = ts.OrderBy(x => Math.Abs((double) x - 0)).First();

            // see if there is a positive match
            var positiveNumber = Math.Abs(nearest);

            foreach (var item in ts)
            {
                if (item == positiveNumber)
                {
                    nearest = item;
                }
            }

            return nearest;
        }

        public bool ExistsInArray(int[] ints, int k)
        {
            if (ints == null)
            {
                ints = new int[] { 1, k };
            }

            var descorder = ints.OrderByDescending(x => x);
            var result = descorder.Contains(k);

            return result;
        }
    }
}
