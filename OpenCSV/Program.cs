using System;
using System.IO;

namespace OpenCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\Shubham\source\repos\Open-CSV\OpenCSV\users.csv";
            string[] lines = File.ReadAllLines(filepath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
