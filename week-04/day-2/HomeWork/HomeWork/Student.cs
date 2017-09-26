using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Student : Person
    {
        public string previousOrganization;
        public int skippedDays;

        public Student(string name = "Jane Doe",
            int age = 30,
            Gender gender = Gender.Female,
            string previousOrganization = "The School of Life") => skippedDays = 0;

        public new void GetGoal() => Console.WriteLine("Be a junior software developer.");

        public new void Introduce() => Console.WriteLine($"Hi, I'm {name}, a(n) {age} year old {gender} from {previousOrganization} who skipped {skippedDays} day(s) from the course already.");

        public void SkipDays(int numberOfDays) => skippedDays += numberOfDays;
    }
}
