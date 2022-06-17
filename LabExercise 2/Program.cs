using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExercise_2
{
    class Movie
    {
        public string strTitle;
        public string strGenre;
        public int intYear;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie objMovie1;
            objMovie1 = new Movie();
            Console.Write("Enter the title: ");
            objMovie1.strTitle = Console.ReadLine();
            Console.Write("Enter the genre: ");
            objMovie1.strGenre = Console.ReadLine();
            Console.Write("Enter the year: ");
            objMovie1.intYear = int.Parse(Console.ReadLine());
            Console.WriteLine("The title is {0} genre is {1} in year {2}",objMovie1.strTitle, objMovie1.strGenre, objMovie1.intYear );
            Movie objMovie2 = new Movie();
            Console.Write("Enter the title: ");
            objMovie2.strTitle = Console.ReadLine();
            Console.Write("Enter the genre: ");
            objMovie2.strGenre = Console.ReadLine();
            Console.Write("Enter the year: ");
            objMovie2.intYear = int.Parse(Console.ReadLine());
            Console.WriteLine("The title is {0} genre is {1} in year {2}", objMovie2.strTitle, objMovie2.strGenre, objMovie2.intYear);

        }
    }
}
