
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/* 
double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");    
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array [i,j] = Math.Round ((new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 2);
    return array;    
} 
void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}
double [,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
 */

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}
/* 
void FindElementOfPosition(int[,] array, int m, int n)
{
    if (0 <= m && m <= array.GetLength(0) - 1 && 0 <= n && n <= array.GetLength(1) - 1)
    {
        Console.WriteLine(array[m, n]);
    }
    else Console.WriteLine("Wrong positions!!!");
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Input a position of rows: ");
int m = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Input a position of columns: ");
int n = Convert.ToInt32(Console.ReadLine()) - 1;

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
Console.Write($"The element of the input positions [{m+1}, {n+1}] is: ");
FindElementOfPosition(myArray, m, n);
Console.WriteLine();
*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FindAvgOfColumns(int[,] array)
{
    
    for(int i = 0; i < array.GetLength(1); i++)
    {
        double avgcolumns = 0;
        for(int j = 0; j < array.GetLength(0); j++)
        {
            avgcolumns = avgcolumns + array[j,i];
            
        }
        avgcolumns = Math.Round(avgcolumns/array.GetLength(0), 2);
        Console.Write(avgcolumns + "; ");
    }
} 

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
FindAvgOfColumns(myArray);
