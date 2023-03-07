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
        public decimal earnings { get; set; }

        public Sportsman(string lastname, int age, string nationality, decimal earnings)
        {
            this.lastname = lastname;
            this.age = age;
            this.nationality = nationality;
            this.earnings = earnings;
        }

        public override string ToString()
        {
            return $"Name:{lastname}, Age:{age}, Nationality:{nationality}, Earnings:{earnings}";
        }
        public static Sportsman operator ++(Sportsman sportsman)
        {
            sportsman.age++;
            return sportsman;
        }
        public static bool operator >(Sportsman a, Sportsman b)
        {
            return a.earnings > b.earnings;
        }
        public static bool operator <(Sportsman a, Sportsman b)
        {
            return a.earnings < b.earnings;
        }
    }
    
}
