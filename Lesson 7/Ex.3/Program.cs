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