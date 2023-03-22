// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = GetRandomArray(12, 100, 999);
Console.WriteLine($"Полученный рандомный массив: [{String.Join(",", array)}]");
System.Console.WriteLine($"Количество положительных трехзначных чисел в массиве = {counNumber(array)}");


// ------------------------------Метод вывода количества четных чисел------------------

int counNumber(int[] Array)
{
    int count = 0;
    // int count2 = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0) count = count + 1;
        // else count2++;
    }

    return count;

}

// -------------------------------Общий метод-------------------------------------------
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = GetRandomArray(10, -10, 10);
Console.WriteLine($"Рандомный массив = [{String.Join(",", array)}]");
System.Console.WriteLine($"Сумма чисел на нечетных индексах = {number(array)}");


// --------------------Находим сумму элементов, стоящих на нечётных индексах.-----------
int number(int[] Array)
{
    
    int number = 0;

    for(int i = 1; i < Array.Length; i += 2 )
    {
        number = number + Array[i];
    }
    return number;
}


// -------------------------------Общий метод-------------------------------------------
int[] GetRandomArray(int size, int minValue, int maxValue)
 {
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
    result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
 }

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.(https://learn.microsoft.com/ru-ru/dotnet/api/system.random.nextdouble?view=net-7.0)
// [3, 7.4, 22.3, 2, 78] -> 76

double[] array = GetRandomArrayRandom(10/*, -10, 10*/);
//Console.WriteLine($"Ранодомный массив = [{String.Join(" , ", array)}]");

double[] array2 = GetRandomArray(array, 1, 100);
Console.WriteLine($"Ранодомный массив = [{String.Join(" , ", array2)}]");

// double[] array = { 3, 7.4, 22.3, 2, 78 }; // Заданный массив из вещественных чисел

System.Console.WriteLine($"В заданном массиве вещественных чисел, максимальное = {Max(array2)}");
System.Console.WriteLine();
System.Console.WriteLine($"В заданном массиве вещественных чисел, минимальное = {Min(array2)}");
System.Console.WriteLine();
System.Console.WriteLine($"Разница между минимальным и максимальным числом массива = {Difference(Min(array2), Max(array2))}");


// --------------Находим максимальное число массива---------------
double Max(double[] Array)
{
    double max = Array[0];

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max) max = Array[i];
    }
    return max;
}

// --------------Находим минимальное число массива-----------------
double Min(double[] Array)
{
    double min = Array[0];

    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] < min) min = Array[i];
    }
    return min;
}

double Difference(double min, double max)
{
    double difference = Math.Round(max - min, 1);
    return difference;
}

// -------------------------------Общий метод-------------------------------------------
double[] GetRandomArrayRandom(int size/*, int minValue, int maxValue*/)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
    result[i] = Math.Round(new Random().NextDouble() /* * 10*/, 1);
    }

    return result;
}


double[] GetRandomArray(double[] array, int minValue, int maxValue)
{
    double size = array.Length; 
    double[] result = new double[Convert.ToInt32(size)];
    for (int i = 0; i < size; i++)
    {
    result[i] = Math.Round(array[i] * new Random().Next(minValue, maxValue + 1), 1);
    }

    return result;
}