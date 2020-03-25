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
            using (var reader = new StreamReader(args[0]))
            {
                string json = reader.ReadToEnd();
                int[] array = JsonConvert.DeserializeObject<int[]>(json);

                int max = Statistics.Maximum(array);
                System.Console.WriteLine(max);
            }
        }
    }
}
