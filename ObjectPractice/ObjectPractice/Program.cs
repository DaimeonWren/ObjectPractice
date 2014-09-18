using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("BMW", "Ix8");
            Car car = new Car();

            Console.WriteLine(myCar.GetInfo());
            Console.WriteLine(car.GetInfo());
            myCar.Honk();
            Student Trai = new Student(1001, "Trai", "Wren");
            // add a course
            Trai.Courses.Add(new Course("Professional Development", "A"));
            Trai.Courses.Add(new Course("Futbol Class", "B"));
            Trai.Courses.Add(new Course("SoftWare Devlopment", "C"));
            Trai.Courses.Add(new Course("English", "A"));
            Trai.Courses.Add(new Course("Calculus", "D"));
            Trai.PrintInfo();

            
            Console.ReadKey();



        }
    }
    
}
