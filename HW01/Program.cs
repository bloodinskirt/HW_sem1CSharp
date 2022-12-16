// Homework

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

//Задача 3.

// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input a 1st number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.Write("Even");
}
else
{
    Console.Write("Odd");
}
*/

//Задача 4.

// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Input a number: ");

int num = Convert.ToInt32(Console.ReadLine());
int cur = 1;

while (cur <= num)
if(cur % 2 == 0)
{
    Console.Write(cur + " ");   
    cur = cur + 1;
}
else
{
    cur = cur + 1;
}
*/
