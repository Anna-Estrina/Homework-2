//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите номер дня недели: ");
int numberOfDay = Convert.ToInt32(Console.ReadLine());
if((numberOfDay == 6) || (numberOfDay == 7))
{
    Console.WriteLine("Да");
}
else if((numberOfDay >= 1) && (numberOfDay < 6))
{
    Console.WriteLine("Нет");
}
else if((numberOfDay < 1) || (numberOfDay > 7))
{
    Console.WriteLine("Такой день не существует");
}
