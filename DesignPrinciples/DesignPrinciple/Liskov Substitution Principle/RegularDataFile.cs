using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DesignPrinciples.DesignPrinciple.Liskov_Substitution_Principle
{
    class RegularDataFile : IFileReader
    {
        public void ReadFile(string filePath)
        {
            // Read File logic    

            string regularData = @"C:\Users\HP\source\repos\DesignPrinciples\RegularData.txt";
            string[] lines = File.ReadAllLines(regularData);
            Console.WriteLine("\nData Successfully read from RegularData\n");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
