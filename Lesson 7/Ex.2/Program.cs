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