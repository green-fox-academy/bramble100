using System;

namespace HomeWork
{
    public class Student : Person, ICloneable
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

        public override void Introduce() => Console.WriteLine(ToString());

        public void SkipDays(int numberOfDays) => skippedDays += numberOfDays;

        public override string ToString()
        {
            return $"Hi, I'm {name}, a(n) {age} year old {gender.ToString().ToLower()} {GetType().Name.ToLower()} from {previousOrganization} who skipped {skippedDays} day(s) from the course already.";
        }
    }
}
