// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string text)
{
    System.Console.Write($"{text}");
    return Convert.ToInt32(Console.ReadLine());
}

double cord(int a, int b)
{
    return Convert.ToDouble((a - b) * (a - b));
}


int AA = Prompt("Введите координату AA: ");
int AB = Prompt("Введите координату AB: ");
int AZ = Prompt("Введите координату AZ: ");
int BA = Prompt("Введите координату BA: ");
int BB = Prompt("Введите координату BB: ");
int BZ = Prompt("Введите координату BZ: ");


// D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)

double A = cord(AA, BA);
double B = cord(AB, BB);
double Z = cord(AZ, BZ);



double coordinate = Math.Sqrt(A + B + Z);

System.Console.WriteLine($"Расстояние в 3D пространстве между точкой А и точкой В = {Math.Round(coordinate, 2)}");