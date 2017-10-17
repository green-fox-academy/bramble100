using System;

namespace HomeWork
{
    class Student : Person, ICloneable
    {
        public string previousOrganization;
        public int skippedDays;

        public Student(string personName = "Jane Doe", 
            int age = 30, 
            Gender personGender = Gender.Female,
            string previousOrganization = "The School of Life",
            int skippedDays = 0) : base(personName, age, personGender)
        {
            this.previousOrganization = previousOrganization;
            this.skippedDays = skippedDays;
        }

        public object Clone()
        {
            return new Student(name, age, gender, previousOrganization, skippedDays);
        }

        new public void GetGoal() => Console.WriteLine("Be a junior software developer.");

        new public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a(n) {age} year old {gender} from {previousOrganization} who skipped {skippedDays} day(s) from the course already.");
        }

        public void SkipDays(int numberOfDays) => skippedDays += numberOfDays;
    }
}
