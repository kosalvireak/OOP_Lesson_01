using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercise_1
{
    class Car
    {
        public string strModel;
        public string strBrand;
        public float fltPrice;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car objCar1; // Declare an object objCar1
            objCar1 = new Car(); // instantiate objCar1
            Console.Write("What is the model of your car: ");
            objCar1.strModel = Console.ReadLine();
            Console.Write("What is the brand of your car: ");
            objCar1.strBrand = Console.ReadLine();
            Console.Write("What is the price of your car: ");
            objCar1.fltPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Car Model is {0} Brand is {1} Price is {2}", objCar1.strModel, objCar1.strBrand, objCar1.fltPrice );

        }
    }
}
