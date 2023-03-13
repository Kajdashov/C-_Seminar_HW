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


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Prompt(string msg){

Console.Write($"{msg}");
return Convert.ToInt32(Console.ReadLine());

}

int number = Prompt("Введите число: ");

int fnumber(int number) {
    
    while (number > 999){

        number = number / 10;
    }
    return number % 10;

}

bool check(int number){

    if (number < 100){
        return false;
    }
    else {
        return true;
    }
}

if (check(number) != true){

    Console.WriteLine($"Вы ввели {number} у этого числа нет третьей цифры, попробуй еще раз.");

}
else{

    Console.WriteLine($"Вы ввели {number}, у этого числа третья цифра -> {fnumber(number)}");

}



// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введите День недели: ");
// int num = int.Parse(Console.ReadLine()!)!;

int Prompt(string outprint)
{

System.Console.Write($"{outprint}");
return Convert.ToInt32(Console.ReadLine());

}

int number = Prompt("Введите число: ");

Console.WriteLine($"{number}");

if ((number < 1) || (number > 7))
{

    Console.WriteLine("Такого дня недели нет, попробуйте еще раз");

}
else {

    if(number > 5){

        Console.WriteLine("Это выходной");

    }
    else{
        Console.WriteLine("Это будний день");
    }

}