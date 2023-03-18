// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// (Задачи, решенные через Math.Pow, не будут считаться правильными, так как задача стоит в том, чтобы написать цикл)

int Prompt(string text)
{
    System.Console.Write($"{text}");
    return Convert.ToInt32(Console.ReadLine());
}

int A = Prompt("Введите число: ");
int B = Prompt("Введите число для возведения в степень: ");

int Sqr(int A, int B)
{
    int sum = A;
    
    for (int i = 2; i <= B; i++)
    {
        sum = sum * A; 
       // System.Console.WriteLine(sum);
    }

    return sum;

}

System.Console.WriteLine(Sqr(A, B));

// -------------------------------------------------------------------------------------

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string text)
{
    System.Console.Write($"{text}");
    return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}

int number = Prompt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);

// ----------------------------------------------------------------------

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int lenArray = 8;  //Prompt("Введите длину массива: "); можно использовать функцию для ввода длины массива

int[] Array = new int[lenArray];

for(int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(1,9);
    System.Console.Write(Array[i] + " ");
}

// int Prompt(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }