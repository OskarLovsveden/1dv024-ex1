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
            Console.WriteLine(data.Maximum);
            Console.WriteLine(data.Minimum);
            Console.WriteLine($"{data.Mean:f1}");
            Console.WriteLine(data.Median);
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
            Console.WriteLine(data.Range);
            Console.WriteLine($"{data.StandardDeviation:f1}");
        }
    }
}