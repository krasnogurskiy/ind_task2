using System;
using ConsoleApp4;

namespace ind_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Sportsman> sportsmen = new List<Sportsman>();

            while (true)
            {
                Console.WriteLine("Do you want to add a new athlete? (Y/N)");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "y")
                {
                    Console.WriteLine("Enter the name of the athlete:");
                    string lastname = Console.ReadLine();

                    Console.WriteLine("Enter the age of the athlete:");
                    int age = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the citizenship of the athlete:");
                    string nationality = Console.ReadLine();


                    Sportsman newSportsman = new Sportsman(lastname,age,nationality);

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
                Console.WriteLine("No sportsmen");
            }
            else 
            {
                List<Sportsman> sportsmen_uk = new List<Sportsman>();
                Console.WriteLine("Sportsmen:");
                foreach (Sportsman sportsman in sportsmen)
                {
                    Console.WriteLine(sportsman.ToString());

                    
                    
                    if (sportsman.nationality.ToLower() == "ukrainian")
                    {
                        sportsmen_uk.Add(sportsman);
                    }

                }
                Console.WriteLine("Sportsman increased age by 1: ");
                foreach(Sportsman sportsman in sportsmen)
                {
                    sportsman.age++;
                    Console.WriteLine(sportsman.ToString());
                }
                Console.WriteLine("Ukrainian sportsmen:");
                foreach (Sportsman s in sportsmen_uk)
                {
                    Console.WriteLine(s.ToString());
                }
                
                
                
            }
            //Footballer f = new Footballer("Messsi",35,"argentina","psg",1234234783m,33);
            //Console.WriteLine(f.ToString());
            //TennisPlayer t1 = new TennisPlayer("Federer",32,"spain",1,23m,435m,846m);
            //Console.WriteLine(t1.ToString());
        }
    }
}

