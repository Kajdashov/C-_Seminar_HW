// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine()!;
int len = num.Length;

if(len == 5)
{
    if(num[0] == num[4] && num[1] == num[3])
    {
        System.Console.WriteLine($"Число {num} панолид");
    }
    else
    {
        System.Console.WriteLine($"Число {num} не панолид");
    }
}
else
{
    System.Console.WriteLine("Вы ввели не пятизначное число");
}


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string text)
{
    System.Console.Write($"{text}");
    return Convert.ToInt32(Console.ReadLine());
}

double cord(int a, int b)
{
    return Convert.ToDouble((a - b) * (a - b));
}

int AA = Prompt("Введите координату AA: ");
int AB = Prompt("Введите координату AB: ");
int AZ = Prompt("Введите координату AZ: ");
int BA = Prompt("Введите координату BA: ");
int BB = Prompt("Введите координату BB: ");
int BZ = Prompt("Введите координату BZ: ");


// D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)

double A = cord(AA, BA);
double B = cord(AB, BB);
double Z = cord(AZ, BZ);

double coordinate = Math.Sqrt(A + B + Z);

System.Console.WriteLine($"Расстояние в 3D пространстве между точкой А и точкой В = {Math.Round(coordinate, 2)}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string text)
{
    System.Console.Write($"{text}");
    return Convert.ToInt32(Console.ReadLine());
}

int number = Prompt("Введите число: ");

for (int i = 1; i <= number; i++)
{
    int sum = (i * i * i);
    System.Console.Write(sum + ", ");
}