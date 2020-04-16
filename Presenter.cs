using System;
namespace examination_1
{
    /// <summary>
    /// Presenter for specific data.
    /// </summary>
    public static class Presenter
    {
        /// <summary>
        /// Presents the specific data.
        /// </summary>
        /// <param name="data"></param>
        public static void Present(dynamic data)
        {
            Console.WriteLine("{0,-20} {1}\n", "Type", "Data");
            Console.WriteLine("{0,-20} {1}", "Maximum:", data.Maximum);
            Console.WriteLine("{0,-20} {1}", "Minimum:", data.Minimum);
            Console.WriteLine("{0,-20} {1}", "Mean:", $"{data.Mean:f1}");
            Console.WriteLine("{0,-20} {1}", "Median:", data.Median);
            Console.Write("{0,-21}", "Mode:");
            for (var i = 0; i < data.Mode.Length; i++)
            {
                if (i != data.Mode.Length - 1)
                {
                    Console.Write(data.Mode[i] + ", ");
                }
                else
                {
                    Console.WriteLine(data.Mode[i]);
                }
            }
            Console.WriteLine("{0,-20} {1}", "Range:", data.Range);
            Console.WriteLine("{0,-20} {1}", "Standard Deviation:", $"{data.StandardDeviation:f1}");
        }
    }
}