using System;
using System.Linq;
using System.Collections.Generic;

namespace examination_1
{
    /// <summary>
    /// Represents a statistics class.
    /// </summary>
    public static class Statistics
    {
        /// <summary>
        /// Copies an array of numbers and sorts it in numerical order.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static int[] CopyAndSortArray(int[] source)
        {
            int[] copy = new int[source.Length];
            source.CopyTo(copy, 0);
            Array.Sort(copy);

            return copy;
        }

        /// <summary>
        /// Creates a new object with the statistics for the passed data.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static dynamic DescriptiveStatistics(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }

            if (source.Length == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            dynamic result = new
            {
                Maximum = Maximum(source),
                Minimum = Minimum(source),
                Mean = Mean(source),
                Median = Median(source),
                Mode = Mode(source),
                Range = Range(source),
                StandardDeviation = StandardDeviation(source)
            };

            return result;
        }

        /// <summary>
        /// Gets the max value in an array containing integers.
        /// </summary>
        /// <param name="source">The source array to get the max value of.</param>
        /// <returns>An integer.</returns>
        public static int Maximum(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            if (source.Length == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            int max = source.Max();
            return max;
        }

        /// <summary>
        /// Gets the min value in an array containing integers.
        /// </summary>
        /// <param name="source">The source array to get the max value of.</param>
        /// <returns>An integer.</returns>
        public static int Minimum(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            if (source.Length == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            int min = source.Min();
            return min;
        }

        /// <summary>
        /// Gets the mean value in an array containing integers.
        /// </summary>
        /// <param name="source">The source array to get the max value of.</param>
        /// <returns>A double.</returns>
        public static double Mean(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            if (source.Length == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            double mean = source.Average();
            return mean;
        }

        /// <summary>
        /// Gets the median value in an array containing integers.
        /// </summary>
        /// <param name="source">The source array to get the max value of.</param>
        /// <returns>A double.</returns>
        public static double Median(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            if (source.Length == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            int[] copy = CopyAndSortArray(source);

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

        /// <summary>
        /// Gets the most frequently occuring values in an array containing integers.
        /// </summary>
        /// <param name="source">The source array to get the data of.</param>
        /// <returns>An array of integers.</returns>
        public static int[] Mode(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            if (source.Length == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            int[] copy = CopyAndSortArray(source);

            Dictionary<int, int> numbers = new Dictionary<int, int>();
            foreach (int number in copy)
            {
                if (numbers.ContainsKey(number))
                {
                    numbers[number]++;
                }
                else
                {
                    numbers[number] = 1;
                }
            }

            int[] numbersArray = numbers.Keys.ToArray();
            int[] occurencesArray = numbers.Values.ToArray();
            int max = Maximum(occurencesArray);

            int[] mode = numbersArray.Where((number, i) => occurencesArray[i] == max).ToArray();

            return mode;
        }

        /// <summary>
        /// Gets the range between the highest and lowest values in an array containing integers.
        /// </summary>
        /// <param name="source">The source array to get the data of.</param>
        /// <returns>An integer.</returns>
        public static int Range(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            if (source.Length == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            int rangeValue = Maximum(source) - Minimum(source);
            return rangeValue;
        }

        /// <summary>
        /// Gets the standard deviation in an array containing integers.
        /// </summary>
        /// <param name="source"></param>
        /// <returns>A double.</returns>
        public static double StandardDeviation(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            if (source.Length == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            double mean = Mean(source);
            double sumOfSquaredNumbers = source.Sum(number => Math.Pow((number - mean), 2));
            double standardDeviation = Math.Sqrt(sumOfSquaredNumbers / (source.Length));

            return standardDeviation;
        }
    }
}