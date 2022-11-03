/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int CutNumber(int number)
{
    int res = number / 10;
    res = res % 10;
    return res;
}
int num = new Random().Next(100,1000);
int result = CutNumber(num);
Console.WriteLine($"New version of a number {num} is {result}");
*/


/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num < 1000)
{
    num = num % 10;
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Tретьей цифры нет");
}
*/


/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int Num (int number)
{

    if (number == 6 || number == 7)
    {
        Console.WriteLine("Выходной");
    }
    else
if (number >= 1 && number <= 5)
{
     Console.WriteLine("Будний");
  
}
else {
     Console.WriteLine("Не верно");

}
}
Console.Write ("nput a number ");
int number = Convert.ToInt32(Console.ReadLine());
int res = Num(number);
*/