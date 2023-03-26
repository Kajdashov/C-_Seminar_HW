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