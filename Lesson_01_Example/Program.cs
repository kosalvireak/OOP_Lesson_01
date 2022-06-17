using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_01_Example
{
    class student
    {
        public int intAge;
        public string strName;
        public string strCourse;
        public string strGroup;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student obj1, obj2; //declaring two object names of type student
            obj1 = new student(); //create object 
            obj2 = new student();
            Console.Write("Enter the name for student 1: ");
            obj1.strName = Console.ReadLine();
            Console.Write("Enter the course name for student 1: ");
            obj1.strCourse = Console.ReadLine();
            Console.Write("Enter the Group name for student 1: ");
            obj1.strGroup = Console.ReadLine();
            Console.Write("Enter the age of student 1: ");
            obj1.intAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Student 1 is {0}, his age is {1}", obj1.strName, obj1.intAge);
        }
    }
}
