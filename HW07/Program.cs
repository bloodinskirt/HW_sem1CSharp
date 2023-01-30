// HM07

// Task 1.

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Random rnd = new Random();
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0); 
          
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");  

        Console.WriteLine();
    }
    Console.WriteLine();      
}

double[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/
// Task 2.

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandomArray()
{
    int rows = new Random().Next(1, 11);
    int columns = new Random().Next(1, 11);
    int min = new Random().Next(0, 11) * (-1);
    int max = new Random().Next(0, 11);
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

int IntGenerator(string message)
{
    Console.Write(message + " = ");
    return Convert.ToInt32(Console.ReadLine());
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");  

        Console.WriteLine();
    }
    Console.WriteLine();      
}

string IndexesCheck(int[,] array, int i, int j)
{
    if (i < array.GetLength(0) && j < array.GetLength(1))
        return $"Element [{i} , {j}] = " + Convert.ToString(array[i, j]);
    else return $"[{i} , {j}] - Index is out of range";
}

int[,] newArray = CreateRandomArray();
Show2dArray(newArray);
int i = IntGenerator("Input a row: ");
int j = IntGenerator("Input a column: ");
Console.WriteLine(IndexesCheck(newArray, i, j));
*/
// Task 3.

// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    int[,] mas = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            mas[i, j] = new Random().Next(min, max + 1);
    return mas;
}

void Show2dArray(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
            Console.Write(mas[i, j] + "\t");
        Console.WriteLine();
    }
}

int IntGenerator(string message)
{
    Console.Write(message + " = ");
    return Convert.ToInt32(Console.ReadLine());
}

double[] ColumnMean(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
            newArray[i] += array[j, i];
        newArray[i] = newArray[i] / array.GetLength(0);
    }
    return newArray;
}

void ShowArray(double[] array, int digits)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{Math.Round(array[i], digits)} : ");
        else Console.Write($"{Math.Round(array[i], digits)}]");
    }
    Console.WriteLine();
}

int rows = IntGenerator("Input rows: ");
int columns = IntGenerator("Input columns: ");
int min = IntGenerator("Input min: ");
int max = IntGenerator("Input max: ");
int[,] newArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(newArray);
int digits = IntGenerator("Input digits: ");
Console.WriteLine("Average result: ");
ShowArray(ColumnMean(newArray), digits);
*/