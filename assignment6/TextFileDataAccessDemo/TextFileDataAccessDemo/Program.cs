using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TextFileDataAccessDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "./test.txt";


            List<Person> people = new List<Person>();

            if (!File.Exists(filePath)){File.WriteAllText(filePath,"");}
            

            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<string> outputLines = new List<string>(); // Initialize outputLines list

            foreach (string line in lines)
            {
                string[] entries = line.Split(',');

                if (entries.Length != 3)
                {
                    Console.WriteLine($"Invalid line: {line}");
                    continue;
                }

                Person p = new Person();
                p.firstName = entries[0];
                p.lastName = entries[1];
                p.Url = entries[2];

                people.Add(p);

                // add another line for the file output.
                outputLines.Add($"First Name: {p.firstName} Last Name: {p.lastName} URL: {p.Url}");
            }

            // print a list of people
            Console.WriteLine("Here is the list of people I have: ");
            foreach (Person p in people)
            {
                // first print to the console.
                Console.WriteLine($"First Name: {p.firstName} Last Name: {p.lastName} URL: {p.Url}");
            }

            // write to another file
            string outPath = "./testout.txt";
            File.WriteAllLines(outPath, outputLines);

            Console.ReadLine();
        }
    }
}