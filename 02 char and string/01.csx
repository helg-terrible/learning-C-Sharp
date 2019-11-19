
string variableName = "puppy"; // определение переменной содержащей строку
string withSlash = "Ifemelu said, \"Hello!\"";  // выделение слова кавычами
string newLine = "Ifemelu walked \n to the park."; // перевод строки 

// конкатенация строк
string yourFaveMusician = "David Bowie";
string myFaveMusician = "Solange";
Console.WriteLine("Your favorite musician is " + yourFaveMusician + " and mine is " + myFaveMusician + ".");

// интерполяция строк
string yourFaveMusician = "David Bowie";
string myFaveMusician = "Solange";

Console.WriteLine($"Your favorite musician is {yourFaveMusician} and mine is {myFaveMusician}.")

// built-in methods
// длинна строки
string userTweet = "45536grgfFDD";
Console.WriteLine(userTweet.Length);

// нахождение подстроки
string word = "radio";
word.IndexOf("a"); // returns 1
/* Since positioning starts at 0, the second thing in the string will return a 1. 
If it doesn’t exist in the string the method will return a -1. 
If we pass it an empty string, it will return 0. If it occurs more than once, 
t will return the first instance.
/*








