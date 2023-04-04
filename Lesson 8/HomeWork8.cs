// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int n = 4;
// int m = 4;

int[,] array = GetArray();
PrintArray(array);
Sort(array);
System.Console.WriteLine();
PrintArray(array);

int[,] GetArray()
{
    int[,] array = new int[4,4];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
    System.Console.WriteLine();
    }
}

void Sort(int[,] arr)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        int temp = array[i, k + 1];
                        array[i, k + 1] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }
}

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

void Print2DArray(int[,] int2DArray)
{

    for (int i = 0; i < int2DArray.GetLength(0); i++)
    {
        for (int j = 0; j < int2DArray.GetLength(1); j++)
        {
            Console.Write($"{int2DArray[i, j]} ");

        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
}

int[,] Create2DimArray(int hight, int length, int min, int max)
{
    int[,] int2DArray = new int[hight, length];

    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < length; j++)
        {
            int2DArray[i, j] = new Random().Next(min, max);
        }
    }

    return int2DArray;
}

bool isInArray(int value, int[,] int2DArray)
{
    foreach (int item in int2DArray)
    {
        if (item == value) return true;
    }
    return false;
}

int countArrayElement(int value, int[,]int2DArray)
{
    int counter = 0;
    foreach (int item in int2DArray)
    {
        if (value == item) counter++;
    }
    return counter;
}

int[,] GetFrequencyArray(int[,] int2DArray)
{
    int[,] frequencyArray = new int[int2DArray.Length, 2];
    int element = 0;
    int zeroElement = 0;

    foreach (int item in int2DArray)
    {
        if (!isInArray(item, frequencyArray) && item != 0)
        {
            frequencyArray[element, 0] = item;
            frequencyArray[element, 1] = countArrayElement(item, int2DArray);
        }
        else if(item == 0 && zeroElement == 0)
        {
            frequencyArray[element, 1] = countArrayElement(item, int2DArray);
            zeroElement++;
        }
        element++;
    }
    return frequencyArray;
}

void PrintFrequencyArray(int[,] frequencyArray)
{
    for (int i = 0; i < frequencyArray.GetLength(0); i++)
    {
        if(frequencyArray[i,1] != 0)
            Console.WriteLine($"{frequencyArray[i,0]} встречается {frequencyArray[i,1]} раз");
    }
}

int[,] myArray = Create2DimArray(3, 3, 1, 10);
Print2DArray(myArray);
int[,] myFrArray = GetFrequencyArray(myArray);
PrintFrequencyArray(myFrArray);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

FillArrayRandom(array);
PrintArray2D(array);

Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray2D(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

PrintArray2D(resultArray);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// // Массив размером 2 x 2 x 2

int[,,] array = new int[2, 2, 2];

FillArray(array);
PrintArray(array);

void PrintArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
            System.Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += count;
                count += 3;
            }
        }
    }
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int rowsColomn = 4;
int[,] array = new int[rowsColomn, rowsColomn];

void FillArray(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        
    }
}
