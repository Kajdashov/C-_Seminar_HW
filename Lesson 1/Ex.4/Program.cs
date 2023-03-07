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