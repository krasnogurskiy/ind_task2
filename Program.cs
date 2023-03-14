using System;
using ConsoleApp4;

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


                    // create a new athlete object using the input values
                    Sportsman newSportsman = new Sportsman(lastname,age,nationality);

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
                List<Sportsman> sportsmen_uk = new List<Sportsman>();

                foreach (Sportsman sportsman in sportsmen)
                {
                    sportsman.age++;
                    Console.WriteLine(sportsman.ToString());
                    if (sportsman.nationality == "ukarinian")
                    {
                        sportsmen_uk.Add(sportsman);
                    }
                    foreach(Sportsman s in sportsmen_uk)
                    {
                        Console.WriteLine(s);
                    }
                   
                }
                
            }
            Footballer f = new Footballer("Messsi",35,"argentina","psg",1234234783m,33);
            Console.WriteLine(f.ToString());
            TennisPlayer t1 = new TennisPlayer("Federer",32,"spain",1,23m,435m,846m);
            Console.WriteLine(t1.ToString());
        }
    }
}
