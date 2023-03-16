// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string text)
{
    System.Console.Write($"{text}");
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt("Введите число: ");

for (int i = 1; i <= number; i++)
{
    int sum = (i * i * i);
    System.Console.Write(sum + ", ");
}