using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicStringFunctionalyty();
            EscapeChars();
            StringEquality();
            StringAreImmutable();
            FunWithStringBuilder();
            StringInterpolation();

            Console.WriteLine(@"C:\MyApp\bin\Debug"); // дословная строка - символ @
            Console.ReadLine();
        }

        static void BasicStringFunctionalyty()
        {
            Console.WriteLine("=> Basic String functionality: ");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            // Значение firstName.
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            // Длина firstname.
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            // firstName в верхнем регистре.
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            // firstName в нижнем регистре.

            // конкатенация строк
            Console.WriteLine("The people is " + "shit");

        }

        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves V'Hello World\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
            // Добавить четыре пустых строки и снова выдать звуковой сигнал.
            Console.WriteLine("All finished.\n\n\n\a ");
            Console.WriteLine();
        }

        static void StringEquality()
        {
            Console.WriteLine("=> String equality:");
            string s1 = "Hello!";
            string s2 = "Yo!";
            Console.WriteLine("si = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();
            // Проверить строки на равенство.
            Console.WriteLine("si == s2: {0}", s1 == s2);
            Console.WriteLine("si == Hello!: {0}", s1 == "Hello!");
            Console.WriteLine("si == HELLO!: {0}", s1 == "HELLO!");
            Console.WriteLine("si == hello!: {0}", s1 == "hello!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Yo.Equals(s2): {0}", "Yo!".Equals(s2));
            Console.WriteLine();
        }

        static void StringAreImmutable()
        {
            // строки не изменяемы
            // Установить начальное значение для строки, 
            string si = "This is my string.";
            Console.WriteLine("si = {0}", si);
            // Преобразована ли строка si в верхний регистр? 
            string upperstring = si.ToUpper();
            Console.WriteLine("upperString = {0}", upperstring);
            // Нет! Строка si осталась в том же виде!
            Console.WriteLine("si = {0}", si);
        }

        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder: ");
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Morrowind");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", "Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);

        }

        static void StringInterpolation()
        {
            // сборка строки методом интерполяции
            int age = 4;
            string name = "Soren";
            string greeting = $"Hello {name} you are {age} years odl";
            Console.WriteLine(greeting);
        }


    }
}
