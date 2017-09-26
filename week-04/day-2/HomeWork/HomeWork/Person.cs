using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Person
    {
        public string name;
        public int age;
        public Gender gender;

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a(n) {age} year old {gender}.");
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }

        public Person(string personName = "Jane Doe", int age = 30, Gender personGender = Gender.Female)
        {
            this.name = personName;
            this.age = age;
            this.gender = personGender;
        }
    }
}
