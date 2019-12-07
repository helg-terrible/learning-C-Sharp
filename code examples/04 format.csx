// Джон говорит.. .
Console.WriteLine ("{0}, Number {0}, Number {0}", 9);
// Выводит: 20, 10, 30
Console.WriteLine ("{1}, {0}, {2}", 10, 20, 30);

// форматирование числовых данных

Console.WriteLine("The value 99999 in various formats:"); 
Console.WriteLine("c format: {0:c}", 99999);
Console.WriteLine("d9 format: {0:d9}", 99999);
Console.WriteLine("f3 format: {0:f3}", 99999);
Console.WriteLine("n format: {0:n}", 99999);
// Обратите внимание, что использование для символа шестнадцатеричного формата 
// верхнего или нижнего регистра определяет регистр отображаемых символов. 
Console.WriteLine ( "Е format: {0:Е}", 99999);
Console.WriteLine ("е format: {0:е}", 99999);
Console.WriteLine("X format: {0:X}", 99999);
Console.WriteLine("x format: {0:x}", 99999);


