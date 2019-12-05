// x - int value
//
// userAnswer - string value, to store answer from user

double x = 0.0;
string userAnswer;

// request value form user
Console.Write("Enter the variable x: ");
userAnswer = Console.ReadLine();

// convers user's answer to double value
x = Convert.ToDouble(userAnswer);

// description of expression
double y = (Math.Pow((5 + x), 2) - 2 * x) / (20 -x);

// output result
Console.WriteLine("Result of calculation: ");
Console.WriteLine(y);

