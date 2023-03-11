Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int sum = (num / 10) % 10;

Console.WriteLine($"Вторая цифра вашего числа {sum}");