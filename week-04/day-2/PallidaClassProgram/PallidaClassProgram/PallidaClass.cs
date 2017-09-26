using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork;

namespace PallidaClassProgram
{
    class PallidaClass
    {
        public string className;
        public List<Student> students = new List<Student>();
        public List<Mentor> mentors = new List<Mentor>();

        public PallidaClass(string className) => this.className = className;

        public void AddStudent(Student student) => students.Add(student);

        public void AddMentor(Mentor mentor) => mentors.Add(mentor);

        public void Info() => Console.WriteLine($"Pallida {className} class has {students.Count} students and {mentors.Count} mentors.");

    }
}