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