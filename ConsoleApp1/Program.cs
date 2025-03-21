using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту параллелипипеда: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину параллепипеда: ");
            double w = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину параллепипеда: ");
            double l = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(GetAreaParallelipiped(h,w,l));
        }
       static double GetAreaParallelipiped(double height, double width, double lenght)
        {
            return (height * width + width * lenght + lenght * height) * 2;
        }
    }
}
