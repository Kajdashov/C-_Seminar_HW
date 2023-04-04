// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int N = ReadInt("Введите число: ");
Console.WriteLine(PrintNumbers(N, 1));

// Функция ввода числа
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Функция вывода натуральных чисел от N до 1
string PrintNumbers(int start, int end)
{
    if(start == end) return start.ToString();
    return (start + " " + PrintNumbers(start - 1, end));
}