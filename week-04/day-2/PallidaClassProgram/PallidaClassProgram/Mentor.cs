using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Mentor : Person
    {
        Level level;

        public Mentor(string personName = "Jane Doe", 
            int age = 30, 
            Gender personGender = Gender.Female, 
            Level level = Level.Intermediate) : base(personName, age, personGender)
        {
            this.level = level;
        }

        public new void GetGoal() => Console.WriteLine("Educate brilliant junior software developers.");

        public new void Introduce() => Console.WriteLine($"Hi, I'm {name}, a(n) {age} year old {gender} {level} mentor.");
    }
}