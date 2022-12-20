// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введи число: ");
int newNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(newNumber);

if (stringNumber.Length < 2)
{
    Console.WriteLine("-> второй цифры нет");
}
else
{
    Console.WriteLine("вторая цифра -> " + stringNumber[1]);
}