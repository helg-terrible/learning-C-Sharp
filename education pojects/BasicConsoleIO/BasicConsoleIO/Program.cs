using System;


namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** Basic Console I/O *****");
            GetUserData();
            // DisplayMessage();
            Console.WriteLine(); 
            Console.ReadLine();
        }

        private static void GetUserData()
        {
            // name and age
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            string userAge = Console.ReadLine();

            // change color front display, just for fun
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            // output received information
            Console.WriteLine("Hey {0}. Your are {1}", userName, userAge);

            // backup above front color
            Console.ForegroundColor = prevColor;

        }

        static void DisplayMessage()
        {
            // Использование string.Format() для форматирования строкового литерала, 
            string userMessage = string.Format("100000 in hex is {0:x}", 100000);
            // Для успешной компиляции этой строки кода требуется 
            // ссылка на библиотеку PresentationFramework.dll!
            //System.Windows.MessageBox.Show(userMessage);
        }
    }
}
