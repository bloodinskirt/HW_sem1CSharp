/*
int a = 5;
double b = 23.6;

bool c = true;      //false

string d = "seminar C#";
char e = 'd';

Console.WriteLine("a, b, c, d, e " + a);
Console.WriteLine($"a, b, c, d, e {a}");

Console.Write("input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
*/

//Задача 1.

//Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
/*
Console.Write("Input a 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a 2st number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)            "==" сравнение(равно ли?)
{
    Console.WriteLine("Yes ");
}
else
{
    Console.WriteLine("No ");
}
*/

//Задача 2.

//Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int cur = -num;

while(cur <= num)
{
    Console.Write(cur + " ");
    cur = cur + 1;              // cur += 1;  cur++; 
}
*/
/*
32465 / 10 = 3246
32465 / 100 = 324
32465 / 1000 = 32
32465 / 10000 = 3

32465 % 10 = 5
32465 % 100 = 65
32465 % 1000 = 465
32465 % 10000 = 2465
*/


// Задача 1.

// Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
/*
Console.Write("Input a 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a 2st number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
 if(num1 > num2)
 {
    Console.Write(num1);
 }
 else
 {
    Console.Write(num2);
 }
 */

// Задача 2.

//Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a 2st number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a 3rd number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(max < num2)
{
    max = num2;
}
if(max < num3)
{
    max = num3;
}
Console.Write(max);
*/