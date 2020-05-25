﻿using System;
using System.Linq;
using System.Reflection;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare some unused variables using types
            //in additional assemblies
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;

            //assigning literal characters
            char letter = 'A';
            char digit = '1';
            char symbol = '$';

            //assigning literal strings
            string firstName ="Bob";
            string lastName = "Smith";
            string phoneNumber = "(215) 555-4256";
            
            //loop through the assemblies that this app references
            foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                //load the assembly so we can read its details
                var a = Assembly.Load(new AssemblyName(r.FullName));
                //declare a variable to count the number of methods
                int methodCount = 0;
                //loop through all the types in the assembly
                foreach (var t in a.DefinedTypes)
                {
                    //add up the counts of methods
                    methodCount += t.GetMethods().Count();
                }

                //output the count of types and their methods
                Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", arg0:a.DefinedTypes.Count(),arg1:methodCount,arg2:r.Name);
            }

            


            //Working with WriteLine Methods
            //outputs a carriage-return
            Console.WriteLine();
            //outpus the greeting and a carriage-return
            Console.WriteLine("Hello Keith");
            //ouputs a formatted number and date and a carriage-return
            Console.WriteLine("Temperature on {0:D} is {1} C.",DateTime.Today,23.4);



            //let the heightInMeter variable become equal to the value 1.88
            double heightInMeters = 1.88;
            Console.WriteLine($"The variable {nameof(heightInMeters)} has the value {heightInMeters}.");

            string fullNameWithTabSeparator = "Bob\tSmith";
            Console.WriteLine(fullNameWithTabSeparator);

            //verbatim literal string
            string filePath = @"C:\televisions\sony\bravia.txt";
            Console.WriteLine(filePath);

        }
    }
}
