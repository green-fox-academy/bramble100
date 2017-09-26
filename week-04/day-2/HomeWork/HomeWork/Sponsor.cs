using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Sponsor : Person
    {
        public string company;
        public int hiredStudent;

        public Sponsor(string personName = "Jane Doe", 
            int age = 30, 
            Gender personGender = Gender.Female, 
            int hiredStudents = 0,
            string company = "Google") : base(personName, age, personGender)
        {
            this.hiredStudent = hiredStudents;
            this.company = company;
        }

        public new void Introduce() => Console.WriteLine($"Hi, I'm {name}, a(n) {age} year old {gender} who represents {company} and hired {hiredStudent} student(s) so far.");

        public void Hire() => hiredStudent++;

        public new void GetGoal() => Console.WriteLine("Hire brilliant junior software developers.");
    }
}