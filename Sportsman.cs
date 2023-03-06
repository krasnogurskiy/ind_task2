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
        
        public Sportsman(string lastname, int age, string nationality)
        {
            this.lastname = lastname;
            this.age = age;
            this.nationality = nationality;
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
    }
    
}
