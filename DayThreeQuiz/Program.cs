using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThreeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCmlength;
            double cmLength;
            double inchLength;
            Console.Write("Please enter the length in cm:");
            inputCmlength = Console.ReadLine();
            cmLength = Convert.ToDouble(inputCmlength);
            inchLength = cmLength / 2.54;
            Console.WriteLine("{0:#0.000}",inchLength);
        }
    }
}
