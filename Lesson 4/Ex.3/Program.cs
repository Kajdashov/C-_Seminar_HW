// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int lenArray = 8;  //Prompt("Введите длину массива: "); можно использовать функцию для ввода длины массива

int[] Array = new int[lenArray];

for(int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(1,9);
    System.Console.Write(Array[i] + " ");
}

// int Prompt(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }