// HW09

// Task 1.

// Задайте значение N. Напишите программу, которая выведет все натуральные
// числа в промежутке от N до 1. Выполнить с помощью рекурсии
/*
void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNumbers(n - 1);
}

Console.Write("Input M: ");
int numM = Convert.ToInt32(Console.ReadLine());
ShowNumbers(numM);
*/
// Task 2.

// Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
/*
void ShowNumbers(int m, int n)
{
    Console.Write(m + " ");
    if(m < n) ShowNumbers(m + 1, n);
    if(m > n) ShowNumbers(m - 1, n);
}

Console.Write("Input M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int numN = Convert.ToInt32(Console.ReadLine());
ShowNumbers(numM, numN);
*/
// Task 3.

// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}
 
Console.WriteLine(Akkerman(1, 2)); 
Console.WriteLine(Akkerman(0, 0)); 
Console.WriteLine(Akkerman(4, 5));
 */