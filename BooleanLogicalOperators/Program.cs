﻿using System;

namespace BooleanLogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pease, enter a Username.");
            string UserName = Console.ReadLine().ToLower();
            Console.WriteLine("Please, enter a Password.");
            string UserPassword = Console.ReadLine();
            if (UserName == "admin" && UserPassword == "admin1234")
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Login failed. Please try again.");
            }
            


            Console.ReadLine();
        }
    }
}
