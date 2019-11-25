
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
Console.WriteLine("Modulo: {0}", (18 % 3)); // позиционное добавление значений

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
*/

// получение подстроки
string plantName = "Cactaceae, Cactus";
int charPosition = plantName.IndexOf("Cactus"); // returns 11
string commonName = plantName.Substring(charPosition); // returns Cactus

// через квадратные скобки
string plantName2 = "Cactaceae, Cactus";
int charPosition2 = plantName2.IndexOf("u"); // returns 15
char u = plantName[charPosition2]; // returns u

// действия над строками







