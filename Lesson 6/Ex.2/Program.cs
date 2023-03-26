// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine("Необходимо ввести данные точек: b1, k1, b2 и k2");

double b1 = Prompt("Введите координату b1: ");
double k1 = Prompt("Введите координату b1: ");
double b2 = Prompt("Введите координату b1: ");
double k2 = Prompt("Введите координату b1: ");

System.Console.WriteLine($"Вы ввели координаты: b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}");

double x = matchX(b1, k1, b2, k2);
double y = matchY(b1, x, k1);


System.Console.WriteLine($"Пересечение в точке: ({x};{y})");

double matchX(double b1, double k1, double b2, double k2)
{
    var x = -(b1 - b2) / (k1 - k2);
    var y = k1 * x + b1;
 
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    return x;
}

double matchY(double b1, double x, double k1)
{
    var y = k1 * x + b1;
 
    y = Math.Round(y, 3);
    return y;
}


double Prompt(string msg)
{
    Console.Write($"{msg}");
    
    return Convert.ToDouble(Console.ReadLine());
}

