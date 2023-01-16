// HW 

// Task 1.

// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
/*
int Degree(int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++)
    {
        result *= A;
    }
    return result;
}
Console.Write("Input a number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = Degree(A, B);
Console.WriteLine(result);
*/
// Task 2.

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum(int num)
{
    int sum = 0;

    while(num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
Console.Write("Input a number: ");
int sum = Convert.ToInt32(Console.ReadLine());
int result = Sum(sum);
Console.WriteLine(result);
*/
// Task 3.

// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
       Console.Write($"Input a {i + 1} element: ");
       array[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        
    Console.WriteLine();
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(length);

ShowArray(newArray);
*/