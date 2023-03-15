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



