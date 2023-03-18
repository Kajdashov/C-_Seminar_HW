// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// (Задачи, решенные через Math.Pow, не будут считаться правильными, так как задача стоит в том, чтобы написать цикл)

int Prompt(string text)
{
    System.Console.Write($"{text}");
    return Convert.ToInt32(Console.ReadLine());
}

int A = Prompt("Введите число: ");
int B = Prompt("Введите число для возведения в степень: ");

int Sqr(int A, int B)
{
    int sum = A;
    
    for (int i = 2; i <= B; i++)
    {
        sum = sum * A; 
       // System.Console.WriteLine(sum);
    }

    return sum;

}

System.Console.WriteLine(Sqr(A, B));