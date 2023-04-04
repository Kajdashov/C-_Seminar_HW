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