using System;

namespace people_age_in_dog_year
{
    class Program
    {
        static void Main(string[] args)
        {
            double man_age = 0.0;
            Console.WriteLine("Enter your age:");
            man_age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You age in a dog year is {0}", Math.Round(man_age / 15));
        }
    }
}
