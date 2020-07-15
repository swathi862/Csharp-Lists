using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //  // Totally fine code
            // List<int> yearsBorn = new List<int>() {
            //     1967, 1969, 1972
            // };

            // int[] itemsSold = new int[] {9, 12, 8, 8, 7, 14, 13, 9};

            // List<string> students = new List<string>() {
            //     "Megan", "Damon", "Chase", "Tekisha",
            //     "Castle", "Mark", "Keith", "Adam",
            //     "Patrick", "Hannah", "Mike"
            // };

            // // Can't do this easily with a base array
            // students.Add("Melanie");
            // students.Insert(3, "Simon");

            // if (students.Contains("Chase")) {
            //     Console.WriteLine("Must be cohort 13");
            // }

            // // This looks a lot like JavaScript!
            // students.ForEach(stu => Console.WriteLine(stu));

            //Exercise #1
            // Add() Jupiter and Saturn at the end of the list.
            // Create another List that contains that last two planet of our solar system.
            // Combine the two lists by using AddRange().
            // Use Insert() to add Earth, and Venus in the correct order.
            // Use Add() again to add Pluto to the end of the list.
            // Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. The rocky planets will remain in the original planets list.
            // Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanetsList = new List<string>(){"Uranus", "Neptune"};

            planetList.AddRange(lastPlanetsList);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            string[] rockyPlanets = planetList.GetRange(0, 4).ToArray();

            foreach( string planet in rockyPlanets )
            {
                Console.WriteLine($"Rocky planet: {planet}");
            }

            planetList.Remove("Pluto");
            planetList.ForEach(planet => Console.WriteLine(planet));

            //Exercise #2: Random Numbers
            Console.WriteLine("\n");
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };
            for (int i=0; i < numbers.Count; i++) {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
                if(numbers.Contains(i)){
                    Console.WriteLine($"numbers list contains {i}");
                }
                else{
                    Console.WriteLine($"numbers list does not contain {i}");
                }

            
            }


        }
    }
}
