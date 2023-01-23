// Task 1.

// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;    
}

int AmoutOfEvenNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 ==0) count++;
    }
    return count;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        
    Console.WriteLine();
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
AmoutOfEvenNums(newArray);
Console.Write(AmoutOfEvenNums(newArray));
*/

// Task 2.

// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;    
}
// counts by index

int EvenIndexPositiions(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if(i % 2 == 0) count++;
    }
    return count;
}


// count by position

int EvenNumsNotIndex(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) count++;
    }
    return count;
}


void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        
    Console.WriteLine();
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);
EvenIndexPositiions(newArray);
Console.Write(EvenIndexPositiions(newArray));
EvenNumsNotIndex(newArray);
Console.Write(EvenNumsNotIndex(newArray));
*/

// Task 3.

// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int length, int minValue, int maxValue)
{
    double[] array = new double[length];

    for (int i = 0; i < length; i++)
        array[i] = new Random().NextDouble(minValue, maxValue);
    
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
Console.Write("Input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, min, max);
ShowArray(newArray);

// Не разобрался как делать эту задачу, буду рад если в комментарии
// объясните как сделать, или наводку какую-нибудь на решение