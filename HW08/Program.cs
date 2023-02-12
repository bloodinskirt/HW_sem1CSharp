// HW08

// Task 1.

// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] New2dArray()
{
    int minValue = 0;
    int maxValue = 100;
    int[,] newArray = new int[5, 5];
    Random rnd = new Random();
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortingNumsInRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int[,] newArray = New2dArray();
Show2dArray(newArray);
SortingNumsInRow(newArray);
Show2dArray(newArray);
*/
// Task 2.

// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
/*
int[,] New2dArray()
{
    int minValue = 0;
    int maxValue = 10;
    int[,] newArray = new int[3, 3];
    Random rnd = new Random();
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumInRow(int[,] array, int i)
{
    int sumRow = array[i, 0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumRow += array[i, j];
    }
    return sumRow;
}

int[,] newArray = New2dArray();
Show2dArray(newArray);

int minSumRow = 0;
int sumRow = SumInRow(newArray, 0);
for (int i = 1; i < newArray.GetLength(0); i++)
{
    int temp = SumInRow(newArray, i);
    if (sumRow > temp)
    {
        sumRow = temp;
        minSumRow = i;
    }
}
Console.Write($"Row with minimum value is {minSumRow + 1}");
*/
// Task 3.

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Please input array rows:  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input array columns:  ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input array minValue:  ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please input array maxValue:  ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2DArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int j = 0; j < result.GetLength(1); j++)
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int i2 = 0, j2 = 0; i2 < matrixB.GetLength(0); i2++, j2++)
                result[i, j] += matrixA[i, j2] * matrixB[i2, j];
        }
    }
    return result;
}

int[,] matrixA = CreateRandom2dArray();
int[,] matrixB = CreateRandom2dArray();
Show2DArray(matrixA);
Show2DArray(matrixB);

if (matrixA.GetLength(1) != matrixB.GetLength(0))
    Console.WriteLine("Can't multiply them");
else
{
    int[,] resMultiply = MultiplyMatrix(matrixA, matrixB);
    Console.WriteLine("Result of multiplying.");
    Show2DArray(resMultiply);
}
*/
// Task 4.

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] CreateRandom3dArray(int rows, int columns, int layers)
{
    int[] maxPossibleNums = new int[90];
    maxPossibleNums[0] = 10;
    for (int n = 1; n < maxPossibleNums.Length; n++)
    {
        maxPossibleNums[n] = maxPossibleNums[0] + n;
    }
    Random rnd = new Random();
    int[,,] array = new int[rows, columns, layers];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < layers; k++)
            {
                do
                {
                    int n = rnd.Next(0, 90);
                    array[i, j, k] = maxPossibleNums[n];
                    maxPossibleNums[n] = 0;
                }
                while (array[i, j, k] == 0);
            }
        }
    }
    return array;
}

void Show3DArray(int[,,] array)
{
    Console.WriteLine();
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ")" + "\t");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
Console.Write("Input rows:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns:  ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input layers:  ");
int layers = Convert.ToInt32(Console.ReadLine());

if (rows * columns * layers > 90)
    Console.WriteLine("Not enough 2-digits number for array.");
else
{
    int[,,] test3dArray = CreateRandom3dArray(rows, columns, layers);
    Show3DArray(test3dArray);
}
*/
// Task 5.

// Напишите программу, которая заполнит спирально массив 4 на 4.
/*
int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

void ShowArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

ShowArray(sqareMatrix);
*/