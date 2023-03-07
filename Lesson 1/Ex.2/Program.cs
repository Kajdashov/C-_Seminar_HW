// Определяем максимальное число из 3-х введенных
// Ввод чисел
Console.WriteLine("Введите 3 числа для определения максимального.");
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int c = int.Parse(Console.ReadLine());

// Максимальное число
int max = a;

// Определение максимального числа
if(b>max) max = b;
if(c>max) max = c;

// Вывод максимального числа
Console.WriteLine($"Максимальное число = {max}");