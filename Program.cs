using System;
using System.Collections.Generic;

namespace ind_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sportsman> sportsmn = new List<Sportsman>();
            sportsmn.Add(new TennisPlayer("Federer", 40, "Switzerland", 1, 1, 1, 30));
            sportsmn.Add(new Footballer("Messi", 34, "Argentina", "Barcelona", 20, 50));
            sportsmn.Add(new Footballer("Ronaldo", 39, "Portugal", "Manchester United", 221, 70));
            sportsmn.Add(new TennisPlayer("Nadal", 42, "Spain", 1, 3, 1, 30));

            Console.WriteLine("Sporsman who ended their career:\n ");
            foreach (Sportsman sportsman in sportsmn)
            {
                if (sportsman.age > 39)
                {
                    sportsman.CareerEndEvent += SportsmanCareerEndEvent;
                    sportsman.EndCareer();
                }
            } 

            sportsmn.Sort();

            Sportsman highestEarner = sportsmn[sportsmn.Count - 1];
            Console.WriteLine($"\n\nThe sportsman with the highest earnings is: {highestEarner}\n\n");
            
            decimal sumEarnings = sportsmn.SumEarnings();
            Console.WriteLine($"The total earnings of sportsmen: {sumEarnings}\n\n");


            List<Sportsman> sportsmen = new List<Sportsman>();

            while (true)
            {
                Console.WriteLine("Do you want to add a new athlete? (Y/N)");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "y")
                {
                    Console.WriteLine("Is the athlete a football player? Y/N");
                    string ansF = Console.ReadLine();

                    if (ansF.ToLower() == "y")
                    {
                        var newFootballer = AddFootballer();
                        sportsmen.Add(newFootballer);
                    }
                    else
                    {
                        Console.WriteLine("Is the athlete a tennis player? Y/N");
                        string ansT = Console.ReadLine();

                        if (ansT.ToLower() == "y")
                        {
                            var newTennis = AddTennisPlayer();
                            sportsmen.Add(newTennis);
                        }
                        else
                        {
                            var newSportsman = AddSportsman();
                            sportsmen.Add(newSportsman);
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
                 List<Sportsman> sportsmen_uk = new List<Sportsman>();
                 Console.WriteLine("\nSportsmen:");

                 foreach (Sportsman sportsman in sportsmen)
                 {
                     Console.WriteLine(sportsman.ToString());



                     if (sportsman.nationality.ToLower() == "ukrainian")
                     {
                         sportsmen_uk.Add(sportsman);
                     }

                 }

                 Console.WriteLine("\nSportsman increased age by 1: ");

                 foreach (Sportsman sportsman in sportsmen)
                 {
                     sportsman.age++;
                     Console.WriteLine(sportsman.ToString());
                 }

                 Console.WriteLine("\nUkrainian sportsmen:");

                 foreach (Sportsman s in sportsmen_uk)
                 {
                     Console.WriteLine(s.ToString());
                 }
            }
        }

  
        private static void SportsmanCareerEndEvent(Sportsman sportsman)
        {
            Console.WriteLine($"{sportsman.lastname} has ended their career.");
        }
       
        static Footballer AddFootballer()
        {
            Console.WriteLine("Enter the name of the footballer:");
            string lastname = Console.ReadLine();

            Console.WriteLine("Enter the age of the footballer:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the citizenship of the footballer:");
            string nationality = Console.ReadLine();

            Console.WriteLine("Enter the club of the footballer:");
            string club = Console.ReadLine();

            Console.WriteLine("Enter the amount of earning from contract:");
            decimal contact = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount of goals:");
            int goals = int.Parse(Console.ReadLine());

            var newFootballer = new Footballer(lastname, age, nationality, club, contact, goals);

            return newFootballer;
        }

        static TennisPlayer AddTennisPlayer()
        {
            Console.WriteLine("Enter the name of the tennis player:");
            string lastname = Console.ReadLine();

            Console.WriteLine("Enter the age of the tennis player:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the citizenship of the tennis player:");
            string nationality = Console.ReadLine();

            Console.WriteLine("Enter the world ranking:");
            int ranking = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of first prizes:");
            decimal prize1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of second prizes:");
            decimal prize2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of third prizes:");
            decimal prize3 = decimal.Parse(Console.ReadLine());

            var newTennis = new TennisPlayer(lastname, age, nationality, ranking, prize1, prize2, prize3);

            return newTennis;
        }

        static Sportsman AddSportsman()
        {
            Console.WriteLine("Enter the name of the athlete:");
            string lastname = Console.ReadLine();

            Console.WriteLine("Enter the age of the athlete:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the citizenship of the athlete:");
            string nationality = Console.ReadLine();

            var newSportsman = new Sportsman(lastname, age, nationality);
            return newSportsman;
        }
    }
}
