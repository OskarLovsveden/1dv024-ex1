using System.Linq;

namespace examination_1
{
    /// <summary>
    /// Represents a statistics class.
    /// </summary>
    public class Statistics
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
    }
}