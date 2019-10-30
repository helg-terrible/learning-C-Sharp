// дан х - целое число
// если х больше 0 - вывести red
// если х равен 0 - вывести yellow
// если х менье 0 - вывести green

Console.WriteLine("Enter a number: ");
int answer = Convert.ToInt32(Console.ReadLine());
string result = "green";

if (answer > 0) {
    result = "red";
}
if (answer == 0) {
    result = "yellow";
}

Console.WriteLine(result);
