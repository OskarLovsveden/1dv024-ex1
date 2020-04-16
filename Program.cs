using System;
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
                int[] data = JsonConvert.DeserializeObject<int[]>(json);

                try
                {
                    dynamic result = Statistics.DescriptiveStatistics(data);
                    Presenter.Present(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
