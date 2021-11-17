using System;
using System.IO;

namespace RandomQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\opilane\samples\Randomquoates.txt";
            string[] datafromfile = File.ReadAllLines(filepath);

            Console.WriteLine(datafromfile[0]);
            Random rnd = new Random();
            int randomtext = rnd.Next(1, datafromfile.Length);
            Console.WriteLine(datafromfile[randomtext]);


            
            

                
             
        }
    }
}
