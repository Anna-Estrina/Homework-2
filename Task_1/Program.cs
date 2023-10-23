// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write ("Введите трёхзначное число:");
string stringNumber = Console.ReadLine();
int number;
bool isNumber = int.TryParse(stringNumber, out number);
if (isNumber && stringNumber.Length == 3)
{
Console.WriteLine($"В строке только цифры");

int firstDigit = number / 100;
int thirdDigit = number % 10;
int result = ((number - (firstDigit * 100 + thirdDigit)) / 10);
Console.WriteLine($"Второе число = {result}");
}
else
{
  Console.WriteLine("В строке есть буквы, либо введено не трёхзначное число");  
}