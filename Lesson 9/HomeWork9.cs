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

// Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int M = ReadInt("Введите число m: ");
int N = ReadInt("Введите число n: ");

CheckingNumbers(M, N);

// Функция ввода числа
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция вычисления функции Аккермана
int Ackermann(int M, int N)
{

    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return Ackermann(M - 1, 1);
    if (M > 0 && N > 0) return Ackermann(M - 1, Ackermann(M, N - 1));
return Ackermann(M, N);
}

// Функция проверки ввода неотрицательных чисел
void CheckingNumbers(int M, int N)
{
    if(M > 0 && N > 0) Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {Ackermann(M, N)}");
    else System.Console.WriteLine("Функция может принимать только неотрицательные числа");
}