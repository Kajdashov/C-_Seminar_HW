// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");

System.Console.WriteLine();

System.Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} = {SumNumber(M - 1, N)}");

// Функция ввода числа
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//Функция подсчета натуральных элементов в промежутке от M до N
int SumNumber (int M, int N)
{
    int sum = M;
    if (M == N) return 0;
    if (M <= N) 
    {
        M++;
        sum = M + SumNumber(M, N);
        //System.Console.WriteLine($"Результат {N} = {sum}");
    }
    return sum;
    
}