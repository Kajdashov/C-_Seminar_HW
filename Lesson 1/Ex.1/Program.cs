Console.WriteLine("Введите 2 числа для определения максимального и минимального.");
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

// if(a > b){
//     Console.Write($"Максимальное число {a}, минимальное число {b}");
// }else{
//     Console.Write($"Максимальное число {b}, минимальное число {a}");
// }

if(a > b) Console.Write($"Максимальное число {a}, минимальное число {b}");
if(a < b) Console.Write($"Максимальное число {b}, минимальное число {a}");
if(a == b) Console.Write($"Числа равны");