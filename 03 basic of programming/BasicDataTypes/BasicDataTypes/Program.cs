using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics; // для типа BigInteger


namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalVarDeclarations();
            NewingDataTypes();
            ObjectFunctionality();
            DataTypeFunctionality();
            CharFunctionality();
            ParseFromString();
            ParseFromStringsWithTryParse();
            UseBigInteger();
            UseDatesAndTimes();
            DigitalSeparators();
            
            Console.ReadLine();
        }

        static void LocalVarDeclarations()
        {
            Console.WriteLine("Data declarations");
            // dataType nameVariable
            int myInt = 0;
            string myString;
            myString = "Character data";
            // объявление трех переменных в одной строке
            bool b1 = true, b2 = false, b3 = b2;
            System.Boolean b4 = false;
            
            Console.WriteLine("Your data: {0} {1} {2} {3} {4} {5}", myInt, myString, b1, b2, b3, b4);
        }

        static void DefaultDeclarations()
        {
            Console.WriteLine("Default declaraions: ");
            int myInt = default; // стандартное значение типа данных
        }

        static void NewingDataTypes()
        {
            // создание переменных через конструктор - 
            // устанавливается стандартное значение переменной
            Console.WriteLine("Using to create variables: ");
            bool b = new bool(); // false
            int i = new int(); // 0
            double d = new double(); // 0.0
            DateTime dt = new DateTime(); // 1/1/0001 12:00:00
            Console.WriteLine($"{b}, {i}, {d}, {dt}");
            Console.WriteLine();
        }

        static void ObjectFunctionality()
        {
            Console.WriteLine("System Object Functionality");
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());

        }

        static void DataTypeFunctionality()
        {
            Console.WriteLine("=> Data type Functionality:");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.Negativelnfinity: {0}", double.NegativeInfinity);
            Console.WriteLine();
        }

        static void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionality:");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit ('a') : {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter ('a') : {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There’, 5): {0}", char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation(’?'): {0}", char.IsPunctuation('?'));
            Console.WriteLine();
        }

        static void ParseFromString()
        {
            Console.WriteLine("=> Data type parsing: "); 
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0} ", b); // Вывод значения b
            //double d = double.Parse("99.884");
            //Console.WriteLine("Value of d: {0} ", d); // Вывод значения d
            int i = int.Parse("8") ;
            Console.WriteLine("Value of l: {0}", i); // Вывод значения i
            //char c = Char.Parse("w");
            //Console.WriteLine("Value of c: {о}", c); // Вывод значения с
            Console.WriteLine();
        }

        static void ParseFromStringsWithTryParse()
        {
            Console.WriteLine("=> Data type parsing with TryParse:");
            if (bool.TryParse("True", out bool b)) ;
            {
                Console.WriteLine("Value of b: {0}", b);  // Вывод значения b
            }
            
            string value = "Hello";
            if (double.TryParse(value, out double d))
            {
                Console.WriteLine("Value of d: {0}", d);  // Вывод значения d
            }
            else
            {
                // Преобразование потерпело неудачу
                Console.WriteLine("Failed to convert the input ({0}) to a double", value);
            }
            Console.WriteLine();
        }
      
        static void UseBigInteger()
        {
            // работа с типом BigInteger
            Console.WriteLine("=> Use BigInteger: ");
            BigInteger biggy = BigInteger.Parse("9999999999999999999999999999999999999999999999");
            Console.WriteLine("Value of biggy is {0}", biggy);
            // значение biggy
            Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
            // biggy - четное?
            Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
            // biggy - степень 2?
            BigInteger reallyBig = BigInteger.Multiply(biggy, BigInteger.Parse("8888888888888888888888888888888888888888888"));
            Console.WriteLine("Value of reallyBig is {0}", reallyBig);
            // значение reallyBig
        }

        static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Dates and Times: ");
            // конструктор принимает год, месяц, день 
            DateTime dt = new DateTime(2015, 10, 17);
            // вывод дня недели
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
            // 
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings {0}", dt.IsDaylightSavingTime());

            // конс-р принимает часы, минуты, секунды
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);
            // вычитаем 15 минут из текущего значения
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));

        }

        static void DigitalSeparators()
        {
            // работа с разделителями
            Console.WriteLine("=> Use Digital Separators: ");
            Console.WriteLine("integer: ");
            Console.WriteLine(123_456);
            Console.WriteLine("Long: ");
            Console.WriteLine(123_456_789L);
            Console.WriteLine("Float: {0}", 123_456.1234F);
            Console.WriteLine("double: {0}", 123_456.12);
            Console.WriteLine("Decimal: {0}", 123_456.12M);
        }
                

    }
}


