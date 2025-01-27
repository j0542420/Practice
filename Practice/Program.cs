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
            //declarations

            //input
            int age = 0;
            double money = 0;

            //asking for input age
            Console.WriteLine("What is your age?");

            //read age
            age = Convert.ToInt32(Console.ReadLine());

            //asking for input money
            Console.WriteLine("How much do you have?");

            //read money
            money = Convert.ToDouble(Console.ReadLine());

            if (age >= 21)
            {
                if (money > 10)
                {
                    Console.WriteLine("Yes! Here is your beer!");
                }
                else
                {
                    Console.WriteLine("You dont have enough money");
                }

            }
            else
            {
                Console.WriteLine("Your are not qualified");
            }


            if (age >= 21 && money >= 10)
            {
                Console.WriteLine("Yes here is your beer");
            }
            else 
            {
                Console.WriteLine("We can not sell you beer!");
            }
            //
            bool isOlder =  ;
            bool isYounger = ;








        }
    }
}
