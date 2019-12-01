using System;

namespace compound_interest
{
    class Program
    {
        static void Main(string[] args)
        {
            double initial_balance = 0.0;
            double interest_rate = 0.0;
            double time_period = 0.0;
            double final_balance = 0.0;

            Console.WriteLine("Enter initial balamce, interest rate, time period: ");
            initial_balance = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("\n");
            interest_rate = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("\n");
            time_period = Convert.ToDouble(Console.ReadLine());

            final_balance = initial_balance * Math.Pow((1 + interest_rate), time_period);

            Console.WriteLine($"Final balance: {final_balance}");
        }
    }
}
