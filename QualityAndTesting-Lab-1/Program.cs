using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityAndTesting_Lab_1
{
    internal class Program
    {
        /// <summary>
        /// Program can define triangle by three angles in args
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            float angle1;
            float angle2;
            float angle3;

            Console.WriteLine("This program is allow you to define the type of triangle by the 3 angles. Please input angles");
            Console.WriteLine("input angle 1");
            string angle = Console.ReadLine();
            if (!float.TryParse(angle, out angle1)) throw new Exception("Program aborted due to incorrect value");
            Console.WriteLine("input angle 2");
            angle = Console.ReadLine();
            if (!float.TryParse(angle, out angle2)) throw new Exception("Program aborted due to incorrect value");
            Console.WriteLine("input angle 3");
            angle = Console.ReadLine();
            if (!float.TryParse(angle, out angle3)) throw new Exception("Program aborted due to incorrect value");

            if (angle1 + angle2 + angle3 != 180) throw new Exception("Values do not give a triangle");

            Program program = new Program();
            string answer = program.DefTriType(angle1, angle2, angle3);
            Console.WriteLine("Triangle is " + answer + ". Press any key for exit");
            Console.ReadKey();
        }

        string DefTriType(float angleA, float angleB, float angleC)
        { 
            if (angleA == 60 && angleA == angleB && angleB == angleC) return "Equilateral";
            else if (angleA == 90 || angleB == 90 || angleC == 90) return "Right_angled";
            else if (angleA == angleB || angleA == angleC || angleB == angleC) return "Isosceles";
            else if (angleA < 90 && angleB < 90 && angleC < 90) return "Acute";
            else if (angleA > 90 || angleB > 90 || angleC > 90) return "Obtuse";
            else return "Scalene";
        }
    }
}
