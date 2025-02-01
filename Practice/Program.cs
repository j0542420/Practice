using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int age = 0;
            double money = 0;

            // Asking for input: age
            Console.WriteLine("What is your age?");
            // Read age
            age = Convert.ToInt32(Console.ReadLine());

            // Asking for input: money
            Console.WriteLine("How much do you have?");
            // Read money
            money = Convert.ToDouble(Console.ReadLine());

            // Check if the user is old enough and has enough money for beer
            bool isOlder = age >= 21;
            bool isYounger = age < 21;

            // Check if the user is old enough for beer and has enough money
            if (isOlder)
            {
                if (money > 10)
                {
                    Console.WriteLine("Yes! Here is your beer!");
                }
                else
                {
                    Console.WriteLine("You don't have enough money.");
                }
            }
            else
            {
                Console.WriteLine("You are not qualified.");
            }

            // Simplified version using the same condition
            if (isOlder && money >= 10)
            {
                Console.WriteLine("Yes, here is your beer.");
            }
            else
            {
                Console.WriteLine("We cannot sell you beer!");
            }

            // Display whether the user is older or younger than 21
            if (isOlder)
            {
                Console.WriteLine("You are older than 21.");
            }
            else
            {
                Console.WriteLine("You are younger than 21.");
            }
        }
    }
}