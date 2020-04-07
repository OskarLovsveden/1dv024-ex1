using System.IO;
using Newtonsoft.Json;

namespace examination_1
{
    /// <summary>
    /// Represents the main place where the program starts the execution.
    /// </summary>
    class Program
    {

        /// <summary>
        /// The starting point of the application.
        /// </summary>
        /// <param name="args">Array containing arguments passed to the application.</param>
        static void Main(string[] args)
        {
            string fileName = args[0];
            using (var reader = new StreamReader(args[0]))
            {
                string json = reader.ReadToEnd();
                int[] array = JsonConvert.DeserializeObject<int[]>(json);

                int max = Statistics.Maximum(array);
                System.Console.WriteLine(max);

                int min = Statistics.Minimum(array);
                System.Console.WriteLine(min);

                double mean = Statistics.Mean(array);
                System.Console.WriteLine($"{mean:f1}");

                double median = Statistics.Median(array);
                System.Console.WriteLine(median);
            }
        }
    }
}
