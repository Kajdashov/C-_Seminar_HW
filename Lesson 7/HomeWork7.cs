// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = Prompt("Введите количество столбцов: ");
int n = Prompt("Введите количество строк: ");

double[,] doubleArray = GetArrayDouble(m, n, 0, 99);
PrintArray(doubleArray);

int Prompt(string msg)
{
    Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}


double[,] GetArrayDouble(int m, int n, int minValue, int maxValue)
{
    double[,] res = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i,j] = Math.Round(new Random().NextDouble() + new Random().Next(maxValue - minValue),2);
        }
    }
    return res;
}

// -----------------Вывод массива-----------------
void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


// Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец), проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том, 
// что оно найдено, а также какое число стоит на этом месте или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 3 -> Такой элемент есть: 3
// i = 4, j = 2 -> такого элемента в массиве нет


int m = Prompt("столбец: ");
int n = Prompt("строка: ");

int[,] array = GetArray(4, 4, 0, 10);
PrintArray(array);
search(array, m, n);

int Prompt(string msg)
{
    Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}


void search(int[,] array, int m, int n)
{
    if(m < array.GetLength(0) || n < array.GetLength(1)) Console.WriteLine($"{m} , {n} -> Такой элемент есть: {array[m, n]}");
    else Console.WriteLine($"{m} , {n} -> такого числа в массиве нет");
}

// ----------------Заполнение массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++){
            res[i, j] = new Random().Next(1,10); 
        }
    }
    return res;
}

// -----------------Вывод массива-----------------
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int n = Prompt("Введите количество столбцов: ");
int m = Prompt("Введите количество строк: ");

System.Console.WriteLine("Полученный массив:");
int[,] array = GetArray(m, n, 0, 10);
System.Console.WriteLine();
PrintArray(array);
searchMatch(array, m, n);

int Prompt(string msg)
{
    Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}

void searchMatch(int [,] array, int m, int n)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[j,i];
        }
        System.Console.WriteLine($"Среднее арифметическое в {i + 1} столбце = {Math.Round(sum / m, 2)}");
        sum = 0;
    }
}

// ----------------Заполнение массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++){
            res[i, j] = new Random().Next(1,10); 
        }
    }
    return res;
}

// -----------------Вывод массива-----------------
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}