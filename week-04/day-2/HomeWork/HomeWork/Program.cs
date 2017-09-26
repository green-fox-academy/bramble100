using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> people = new List<Student>()
            {
                new Student()
            };

            people[0].Introduce();
            //people.Add(new Person("Mark", 46, Gender.Male));
            //people.Add(new Person());
            //people.Add(new Student("John Doe", 20, Gender.Male, "BME"));
            //Student student = new Student();
            //people.Add(student);
            //people.Add(new Mentor("Gandhi", 148, Gender.Male, Level.Senior));
            //Mentor mentor = new Mentor();
            //people.Add(mentor);
            //Sponsor sponsor = new Sponsor();
            //Sponsor elon = new Sponsor("Elon Musk", 46, Gender.Male, "SpaceX");

            //student.SkipDays(3);

            //for (int i = 0; i < 5; i++)
            //{
            //    elon.Hire();
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    sponsor.Hire();
            //}

            //foreach (Person person in people)
            //{
            //    person.Introduce();
            //    person.GetGoal();
            //}

            Console.ReadKey();
        }
    }
}
