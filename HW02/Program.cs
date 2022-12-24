// HW

// Задача 1.
 
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
/*
int ShowNumber(int number)
{
    int first = number / 100;
    int last = number % 10;
    int mid = number / 10 % 10;

    int result = mid;
    return result;
}

Console.Write("Input a three - digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNumber =  ShowNumber(num);

Console.WriteLine($"New version of number {num} is {newNumber}");
*/

// Задача 2.

// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
/*
int TrirdNumber(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result; 
}

Console.Write("Input three-digit number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int newNum = TrirdNumber(number1);
if(newNum == -1)
{
    Console.Write("There is no 3rd digit");
}
else
{
    Console.Write($"Trird digit is {newNum}");
}
*/

// Задача 3.

// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
/*
int WeekendDay(int number)
{
    int result = 0;
    if(number == 6 || number ==7)
    {
        Console.Write("Its weekend!");
    }
    else
    {
        Console.Write("Its not weekend");
    }
    return result;
}

Console.Write("Input a day number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int number2 = WeekendDay(number1);
*/