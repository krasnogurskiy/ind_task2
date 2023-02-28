using System;
using System.Collections.Generic;
using System.Text;

namespace ind_task2
{
    class Sportsman
    {
        private string lastname;
        private int age;
        private string nationality;

        public Sportsman()
        {
            lastname = "";
            age = 0;
            nationality = "";
        }

        public Sportsman(string _lastname, int _age, string _nationality)
        {
            this.lastname = _lastname;
            this.age = _age;
            this.nationality = _nationality;
        }

        public override string ToString()
        {
            return $"{lastname}, {age}, {nationality}";
        }
    }
}
