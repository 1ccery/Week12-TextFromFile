using System;
using System.IO;


namespace Seasons
{
    class Program
    {
        static void Main(string[] args)
        {
            string autmnpath = @"C:\Users\opilane\samples\autumn.txt";
            string winterpath = @"C:\Users\opilane\samples\winter.txt";
            string[] datafromautumn = File.ReadAllLines(autmnpath);
            string[] datafromwinter = File.ReadAllLines(winterpath);

            File.WriteAllLines(autmnpath, datafromwinter);
            File.WriteAllLines(winterpath, datafromautumn);
        }
    }
}
