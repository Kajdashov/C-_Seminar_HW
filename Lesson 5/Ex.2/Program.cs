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