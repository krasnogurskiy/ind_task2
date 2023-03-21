﻿using System;
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
                    // спитати чи тенісист чи футболіст (сфрмулювати окреммі списки для футболістів та тенісистів, як варіант)ee
                    // 2 варіант так як є але закинути перше всіх футболістів в оди контейнер, а інших в другий, вкінці вивести під одним 'предлогом'
                    Console.WriteLine("ia a Sportman a football player? Y/N");
                    string ansF = Console.ReadLine();
                    
                    if(ansF.ToLower() == "y")
                    {
                       
                        // prompt the user to enter the details of a new athlete
                        Console.WriteLine("Enter the name of the athlete:");
                        string lastname = Console.ReadLine();

                        Console.WriteLine("Enter the age of the athlete:");
                        int age = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the citizenship of the athlete:");
                        string nationality = Console.ReadLine();

                        // create a new athlete object using the input values
                        Sportsman newFootballer = new Sportsman(lastname,age,nationality);

                        // add the new athlete object to the list of athletes
                        sportsmen.Add(newFootballer);
                    }
                    else if (ansF.ToLower() == "n")
                    {
                        Console.WriteLine("ia a Sportman a tennis player? Y/N");
                        string ansT = Console.ReadLine();

                        if (ansT.ToLower() == "y")
                        {

                        // prompt the user to enter the details of a new athlete
                            Console.WriteLine("Enter the name of the athlete:");
                            string lastname = Console.ReadLine();

                            Console.WriteLine("Enter the age of the athlete:");
                            int age = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter the citizenship of the athlete:");
                            string nationality = Console.ReadLine();

                            // create a new athlete object using the input values
                            Sportsman newTennis = new Sportsman(lastname, age, nationality);

                            // add the new athlete object to the list of athletes
                            Console.WriteLine("Tennis Player!");
                            sportsmen.Add(newTennis);
                        }
                        else
                        {
                            Console.WriteLine("Enter the name of the athlete:");
                            string lastname = Console.ReadLine();

                            Console.WriteLine("Enter the age of the athlete:");
                            int age = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter the citizenship of the athlete:");
                            string nationality = Console.ReadLine();

                            // create a new athlete object using the input values
                            Sportsman newTennis = new Sportsman(lastname, age, nationality);

                            // add the new athlete object to the list of athletes
                            Console.WriteLine("Sporsman fron another kind of sport! Not a football player, not a tennis player!");
                            sportsmen.Add(newTennis);
                        }
                            
                    }

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
