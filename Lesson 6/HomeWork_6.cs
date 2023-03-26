// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.Write("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = new int[size];

int[] Array(int[] arr, int s)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"Введите {i + 1} элемент массива: ");
        arr[i] = int.Parse(Console.ReadLine()!);
    }
    return arr;
}

int sort(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}

System.Console.WriteLine($"Введенный массива = [{String.Join(" , ", Array(array, size))}]");
System.Console.WriteLine($"Чисел больше нуля в массиве -> {sort(array)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Необходимо ввести данные точек: b1, k1, b2 и k2");

double b1 = Prompt("Введите координату b1: ");
double k1 = Prompt("Введите координату b1: ");
double b2 = Prompt("Введите координату b1: ");
double k2 = Prompt("Введите координату b1: ");

System.Console.WriteLine($"Вы ввели координаты: b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}");

double x = matchX(b1, k1, b2, k2);
double y = matchY(b1, x, k1);


System.Console.WriteLine($"Пересечение в точке: ({x};{y})");

double matchX(double b1, double k1, double b2, double k2)
{
    var x = -(b1 - b2) / (k1 - k2);
    var y = k1 * x + b1;
 
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    return x;
}

double matchY(double b1, double x, double k1)
{
    var y = k1 * x + b1;
 
    y = Math.Round(y, 3);
    return y;
}


double Prompt(string msg)
{
    Console.Write($"{msg}");
    
    return Convert.ToDouble(Console.ReadLine());
}

