// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int Prompt(string outprint)
// {

// System.Console.Write($"{outprint}");
// string st = Console.ReadLine()!;
// return st;
// }




System.Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine()!;
int len = num.Length;

if(len == 5)
{
    if(num[0] == num[4] && num[1] == num[3])
    {
        System.Console.WriteLine($"Число {num} панолид");
    }
    else
    {
        System.Console.WriteLine($"Число {num} не панолид");
    }
}
else
{
    System.Console.WriteLine("Вы ввели не пятизначное число");
}