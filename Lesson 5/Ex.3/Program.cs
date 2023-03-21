// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.(https://learn.microsoft.com/ru-ru/dotnet/api/system.random.nextdouble?view=net-7.0)
// [3, 7.4, 22.3, 2, 78] -> 76

// double[] array = GetRandomArray(10, -10, 10);
// Console.WriteLine($"Ранодомный массив = [{String.Join(",", array)}]");

double[] array = { 3, 7.4, 22.3, 2, 78 }; // Заданный массив из вещественных чисел

System.Console.WriteLine($"В заданном массиве вещественных чисел, максимальное = {Max(array)}");
System.Console.WriteLine();
System.Console.WriteLine($"В заданном массиве вещественных чисел, минимальное = {Min(array)}");
System.Console.WriteLine();
System.Console.WriteLine($"Разница между минимальным и максимальным числом массива = {Difference(Min(array), Max(array))}");


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
    double difference = max - min;
    return difference;
}









// -------------------------------Общий метод-------------------------------------------
// double[] GetRandomArray(int size, int minValue, int maxValue)
//             {
//                 double[] result = new double[size];
//                 for (int i = 0; i < size; i++)
//                 {
//                     result[i] = new Random().NextDouble(minValue, maxValue + 1);
//                 }

//                 return result;
//             }