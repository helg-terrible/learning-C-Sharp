double height = 0.0;
double widht = 0.0;
string userAnswer;

Console.WriteLine("Type value height and widht of triangle");

Console.WriteLine("height: ");
userAnswer = Console.ReadLine();
height = Convert.ToDouble(userAnswer);

Console.Write("width: ");
userAnswer = Console.ReadLine();
widht = Convert.ToDouble(userAnswer);

double Per = 2 * (height + widht);
double Area = height * widht;

// вывод периметра и площади
Console.Write("Per: ");
Console.WriteLine(Per);
Console.Write("Area: ");
Console.WriteLine(Area);





