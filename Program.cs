using System;

namespace RhythmsGonnaGetYou
{
    class Program
    {
        static void Main(string[] args)





        {

            Console.WriteLine("Hi there! Welcome to the Record Company Database");

            var quit = false;

            while (quit == false)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Would you like to [A]dd a new band?: ");







                var choice = Console.ReadLine().ToUpper();
                if (choice == "A")
                {
                    Console.WriteLine("What is the new band's name?");
                    var name = Console.ReadLine();


                }




            }




        }












    }
}
