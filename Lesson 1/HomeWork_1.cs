// Задание 2
// Определяем максимальное и минимально число
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

// Задание 4
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

// Задание 6
// Определяем число четное или нечетное
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if(number % 2 == 0){
    Console.WriteLine("Число четное");
} else{
    Console.WriteLine("Число нечетное");
}

// Задание 8
// Программа которая показывает все четные числа до введенного числа
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int count = 1;

while(count <= num){
    if(count % 2 != 1){
        Console.Write($"{count}, ");
        count++;
    }
    else{
        count++;
    }
}