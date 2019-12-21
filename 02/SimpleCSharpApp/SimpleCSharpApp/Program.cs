using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        // класс program, содержащий метод main - объект приложения
        // main - точка входа в приложение
        static int Main(string[] args)
        {
            // Вывести пользователю простое сообщение.
            Console.WriteLine("***** My First C# Арр *****");
            Console.WriteLine("Hello World");

            // получим аргументы командной строки с использованием System.Environment
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
                Console.WriteLine("Arg: {0}", arg);

            // вывод деталей окружения
            ShowEnvironmentDetails(); // вспомогательный метод
                                    
            Console.WriteLine();
            // Ожидать нажатия клавиши <Enter>, прежде чем завершить работу. 
            Console.ReadLine();

            return -1; // пример возврата кода ошибки
        }

        static void ShowEnvironmentDetails()
        {
            // вывод информации о дисках
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            // версия ОС
            Console.WriteLine("OS version {0}", Environment.OSVersion);

            // вывод количества процессоров
            Console.WriteLine("Numbr of CPU: {0}", Environment.ProcessorCount);

            // вывод количества процессоров
            Console.WriteLine(".NET Version: {0}", Environment.Version);

            // полный путь системной директории
            Console.WriteLine("System directory: {0}", Environment.SystemDirectory);



        }
    }
}
