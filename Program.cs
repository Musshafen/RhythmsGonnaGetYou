﻿using System;

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
                Console.WriteLine("Would you like to [V]iew all the bands?");






                var choice = Console.ReadLine().ToUpper();
                if (choice == "A")
                {
                    Console.WriteLine("What is the new band's name?");
                    var name = Console.ReadLine();
                    Console.WriteLine("What is the new band's country of origin?");
                    var countryOfOrigin = Console.ReadLine();
                    Console.WriteLine("How many members are in the new band?");
                    var numbersOfMembers = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the new band's website?");
                    var website = Console.ReadLine();
                    Console.WriteLine("What is the new band's genre?");
                    var genre = Console.ReadLine();
                    Console.WriteLine("Is the new band signed?");
                    var isSigned = Boolean.Parse(Console.ReadLine());
                    Console.WriteLine("What is the new band's contact name?");
                    var contactName = Console.ReadLine();
                    Console.WriteLine("What is the new band's contact phone number?");
                    var contactPhoneNumber = Console.ReadLine();

                    var newBand = new Bands
                    {
                        Name = name,
                        CountryOfOrigin = countryOfOrigin,
                        NumberOfMembers = numbersOfMembers,
                        Website = website,
                        Genre = genre,
                        IsSigned = isSigned,
                        ContactName = contactName,


                    };


                }
                if (choice == "V")
                {
                    //foreach (var band in bands)
                    {
                        //    Console.WriteLine(band.Name);
                    }

                }

            }




        }












    }
}
