// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Write("Введите трехзначное число: ");
// int num = int.Parse(Console.ReadLine()!)!;

int Prompt(string msg)
{

Console.WriteLine($"{msg}");
return Convert.ToInt32(Console.ReadLine());

}

int num = Prompt("Введите трехзначное число: ");

if ( ( num < 100 ) || ( num >= 1000 ) )
{

    Console.WriteLine( "Вы ввели не трехзначное число, " );
    Console.WriteLine( "Попробуйте заново." );   
   
} 
    else
    {

        int sum = ( num / 10 ) % 10;
        Console.WriteLine( $"Вторая цифра вашего числа {sum}" );

    }
