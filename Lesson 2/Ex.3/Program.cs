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