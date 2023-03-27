using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ind_task2
{
    public class Sportsman
    {
        public string lastname { get; set; }
        public int age { get; set; }
        public string nationality { get; set; }
        

        public Sportsman()
        {
            lastname = string.Empty;
            age = 0;
            nationality = string.Empty;
        }
      
        public Sportsman(string lastname, int age, string nationality)
        {
            this.lastname = lastname;
            this.age = age;
            this.nationality = nationality;
        }
        public virtual decimal CalculateEarnings()
        {
            return 0;
        }
        public override string ToString()
        {
            return $"Name:{lastname}, Age:{age}, Nationality:{nationality}";
        }
        public static Sportsman operator ++(Sportsman sportsman)
        {
            sportsman.age++;
            return sportsman;
        }
        public static bool operator >(Sportsman a, Sportsman b)
        {
            return a.CalculateEarnings() > b.CalculateEarnings();
        }
        public static bool operator <(Sportsman a, Sportsman b)
        {
            return a.CalculateEarnings() < b.CalculateEarnings();
        }
    }
    public class TennisPlayer : Sportsman
    {
        public int Ranking { get; set; }
        public decimal Prize1 { get; set; }
        public decimal Prize2 { get; set; }
        public decimal Prize3 { get; set; }

        public TennisPlayer() : base()
        {
            Ranking = 0;
            Prize1 = 0;
            Prize2 = 0;
            Prize3 = 0;
        }
        public TennisPlayer(string lastname, int age, string nationality, int ranking, decimal prize1, decimal prize2, decimal prize3) : base(lastname, age, nationality)
        {
            Ranking = ranking;
            Prize1 = prize1;
            Prize2 = prize2;
            Prize3 = prize3;
        }
        public override decimal CalculateEarnings()
        {
            return Prize1 + Prize2 + Prize3;
        }
        public override string ToString()
        {
            return $"Name:{lastname}, Age:{age}, Income:{CalculateEarnings()}";
        }
    }
     public class Footballer : Sportsman
    {
        public string Club { get; set; }
        public decimal AnnualContract { get; set; }
        public int GoalsScored { get; set; }

        public Footballer(string lastname, int age, string nationality, string club, decimal contract, int goals) : base(lastname, age, nationality)
        {
            Club = club;
            AnnualContract = contract ;
            GoalsScored = goals;   
        }
        public override decimal CalculateEarnings()
        {
            return AnnualContract*(1+ GoalsScored / 100m);
        }

        
        public override string ToString()
        {
            return $"Name:{lastname}, Age:{age}, Income:{CalculateEarnings()}";
        }
    }
}

