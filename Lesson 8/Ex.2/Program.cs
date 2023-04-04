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