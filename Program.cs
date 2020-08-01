using System;
using System.Collections.Generic;

namespace planet_and_spaceships
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            // Add() Jupiter and Saturn at the end of the list
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            // test
            // planetList.ForEach(planet => Console.WriteLine(planet));

            // Create another List that contains that last two planet of our solar system.

            List<string> planetList2 = new List<string>(){"Uranus", "Neptune"};

            // test
            // planetList2.ForEach(planet => Console.WriteLine(planet));

            
        }
    }
}
