// HW 3

// Задача 1.

// Напишите программу, которая принимает на вход любое
// число и проверяет, является ли оно палиндромом.
/*
bool Palindrom(int number)
{
    int result = 0;
    int num = number;
    while(number > 0)
    {
        result = result * 10 + number % 10;
        number = number / 10;
    }
    return result == num;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(Palindrom(number))
{
    Console.WriteLine("Its Palindrom");
}
else
{
    Console.WriteLine("Its not palindrom");
}
*/

// Задача 2.

// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
/*
double Lenght(double x1, double y1, double x2, double y2, double z1, double z2)
{ 
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 -z1, 2));
}

Console.Write("Input x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.Write(Lenght(x1, y1, x2, y2, z1, z2));
*/

// Задача 3.

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void WriteThirds(int number)
{
    int count = 1;
    while(count <= number)
    {
        Console.Write(Math.Pow(count, 3) + " ");
        count++;
    }
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

WriteThirds(number);
*/