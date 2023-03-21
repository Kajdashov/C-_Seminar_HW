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