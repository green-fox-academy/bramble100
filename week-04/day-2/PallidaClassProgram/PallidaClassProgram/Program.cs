using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork;

namespace PallidaClassProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            PallidaClass Alpaga = new PallidaClass("Alpaga");
            Alpaga.AddMentor(new Mentor());
            Alpaga.AddMentor(new Mentor());
            Alpaga.AddStudent(new Student());
            Alpaga.AddStudent(new Student());
            Alpaga.AddStudent(new Student());
            Alpaga.Info();
            Console.ReadKey();
        }
    }
}
