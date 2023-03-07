using System;
using System.Collections.Generic;

namespace ind_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // create a list to hold the athletes
            List<Sportsman> sportsmen = new List<Sportsman>();

            // prompt the user to add athletes
            while (true)
            {
                Console.WriteLine("Do you want to add a new athlete? (Y/N)");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "y")
                {
                    // prompt the user to enter the details of a new athlete
                    Console.WriteLine("Enter the name of the athlete:");
                    string lastname = Console.ReadLine();

                    Console.WriteLine("Enter the age of the athlete:");
                    int age = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the citizenship of the athlete:");
                    string nationality = Console.ReadLine();

                    Console.WriteLine("Enter the earnings of the athlete:");
                    decimal earnings = decimal.Parse(Console.ReadLine());


                    // create a new athlete object using the input values
                    Sportsman newSportsman = new Sportsman(lastname,age,nationality, earnings);

                    // add the new athlete object to the list of athletes
                    sportsmen.Add(newSportsman);
                }
                else if (answer.ToLower() == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid answer. Please enter Y or N.");
                }
            }
            if (sportsmen.Count == 0)
            {
                Console.WriteLine("No athletes");
            }
            else
            {
                // print the list of athletes
                foreach (Sportsman sportsman in sportsmen)
                {
                    // increase the athlete`s age by 1
                    sportsman.age++;                            
                    Console.WriteLine(sportsman.ToString());
                }
            }
        }
    }
}
