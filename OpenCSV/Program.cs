using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OpenCSV
{
    /// <summary>
    /// Driver class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main Function to parse CSV into CSVUsers Class.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //CSV file's path.
            string filepath = @"C:\Users\Shubham\source\repos\Open-CSV\OpenCSV\users.csv";

            //List to store the CSVUsers Object.
            List<CSVUsers> users = new List<CSVUsers>();
            
            //List to store the lines from file.
            List<string> lines = File.ReadAllLines(filepath).ToList();

            //Loop to set the data to CSVUsers object and storing that object to List.
            foreach (string line in lines)
            {
                string[] entries = line.Split(",");
                CSVUsers user = new CSVUsers();
                user.Name = entries[0];
                user.Email = entries[1];
                user.PhoneNo = entries[2];
                user.Country = entries[3];
                users.Add(user);
            }

            //Loop to print the Data From CSVUsers type List.
            foreach (CSVUsers user in users)
            {
                Console.WriteLine($"{user.Name} : {user.Email} : {user.PhoneNo} : {user.Country}");
            }

            //New user data.
            users.Add(new CSVUsers { Name="Shubham Deulkar",Email="Shubhamdeulakr27@gmail.com", PhoneNo="+91-88787985652",Country="India" });
            
            //List to to store new as well as old user data.
            List<string> output = new List<string>();

            //Storing the Whole User Data to the output List.
            foreach (CSVUsers user in users)
            {
                output.Add($"{user.Name},{user.Email},{user.PhoneNo},{user.Country}");
            }

            //WriteLine 
            File.WriteAllLines(filepath,output);
            Console.WriteLine("All Entries Are Written");
        }
    }
}
