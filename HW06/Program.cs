// HW06

// Task 1.

// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int count = 0;
Console.WriteLine("Input amount of numbers: ");
int m = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    Console.WriteLine("Input a number: ");
    int num = int.Parse(Console.ReadLine());
    if (num >= 0)
    {
        count++;
    }
}
Console.WriteLine("Numbers equal to 0: " + count);
*/
// Task 2.

// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.Write("Input a b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a k1: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if(k1 == k2 && b1 == b2) Console.Write("Lines match");
else if(k1 == k2 && b1 != b2) Console.Write("Lines are parallel");
else
{
    double x = (b2 - b1) / (k2 - k1);
    double y = k2 * x + b2;
    Console.WriteLine($"Two line will cross at X:{x} and Y:{y}");
}
*/