using System;
using System.IO;

namespace BlackSheep
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullfilepath = @"C:\Users\opilane\Samples\blacksheep.txt";
            string[] datafromfile = File.ReadAllLines(fullfilepath);


            for (int i = 0; i < datafromfile.Length; i++)
            {
                datafromfile[i] = datafromfile[i].Replace('4', 'a');
                datafromfile[i] = datafromfile[i].Replace('3', 'e');
                datafromfile[i] = datafromfile[i].Replace('0', 'o');
                datafromfile[i] = datafromfile[i].Replace('1', 'i');
            }

            foreach (string line in datafromfile)
            {
                Console.WriteLine(line);
            }
            File.WriteAllLines(fullfilepath, datafromfile);
        }

        
        
            

        

    }
}
