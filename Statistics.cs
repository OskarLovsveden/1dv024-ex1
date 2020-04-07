using System;
using System.Linq;

namespace examination_1
{
    /// <summary>
    /// Represents a statistics class.
    /// </summary>
    public static class Statistics
    {
        /// <summary>
        /// Gets the max value of an array containing numbers.
        /// </summary>
        /// <param name="source">The source array to get the max value of.</param>
        /// <returns></returns>
        public static int Maximum(int[] source)
        {
            int max = source.Max();
            return max;
        }

        /// <summary>
        /// Gets the min value of an array containing numbers.
        /// </summary>
        /// <param name="source">The source array to get the max value of.</param>
        /// <returns></returns>
        public static int Minimum(int[] source)
        {
            int min = source.Min();
            return min;
        }

        /// <summary>
        /// Gets the mean value of an array containing numbers.
        /// </summary>
        /// <param name="source">The source array to get the max value of.</param>
        /// <returns></returns>
        public static double Mean(int[] source)
        {
            double mean = source.Average();
            return mean;
        }

        /// <summary>
        /// Gets the median value of an array containing numbers.
        /// </summary>
        /// <param name="source">The source array to get the max value of.</param>
        /// <returns></returns>
        public static double Median(int[] source)
        {
            int[] copy = new int[source.Length];
            source.CopyTo(copy, 0);

            Array.Sort(copy);
            int copyLength = copy.Length;

            if (copyLength % 2 != 0)
            {
                double median = copy[copyLength / 2];
                return median;
            }
            else
            {
                int lowIndex = (copyLength - 1) / 2;
                int highIndex = copyLength / 2;

                double median = (copy[lowIndex] + copy[highIndex]) / 2;
                return median;
            }
        }
    }
}