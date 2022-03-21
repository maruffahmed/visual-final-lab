using System;
using System.Collections.Generic;
using System.Text;

namespace LabFinalProblemPractice
{
    class Qus2
    {
        static public void ans()
        {
            double number = Convert.ToDouble(Console.ReadLine());
            if (number == 0) Console.WriteLine("Zero");
            else if (number< 0) Console.WriteLine("negative");
            else Console.WriteLine("positive");

            if (Math.Abs(number) < 1) Console.WriteLine("small");
            else if (Math.Abs(number) > 1000000) Console.Write("large");

        }
    }
}
