using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OpenCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\Shubham\source\repos\Open-CSV\OpenCSV\users.csv";
            List<string> lines = File.ReadAllLines(filepath).ToList();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
