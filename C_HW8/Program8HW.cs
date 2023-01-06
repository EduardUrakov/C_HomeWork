

/* int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columnss: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

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
} */

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/* 
void SortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(1) - 1; z++)
            {
                if (array[i,z] < array[i,z+1])
                {
                    int temp = array[i,z+1];
                    array[i,z+1] = array[i,z];
                    array[i,z] = temp;
                }
            }
        }
    }
}

int [,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
SortRows(myArray);
Console.WriteLine();
Show2dArray(myArray);

 */


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/* 
void LittleSumOfRow(int[,] array)
{
    int sumRow = 0;
    int minRow = 0;
    int LittleSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        minRow += array[0, j];
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                sumRow += array[i, j];
                {
                    if (sumRow < minRow)
                    {
                        minRow = sumRow;
                        LittleSum = i;
                    }
                    sumRow = 0;  
                }
            }
        }
    Console.Write($"The minimal sum of numbers in row: {LittleSum + 1}"); 
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
LittleSumOfRow(myArray);

 */


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/* 
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

int[,] DubleArray(int[,] array, int[,] secondarray)
{
    int[,] resultArray = new int[array.GetLength(0), secondarray.GetLength(1)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < secondarray.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(1); k++)
            {
                {
                resultArray[i,j] += array[i,k] * secondarray[k,j];
                }
            }
        }
    }
return resultArray;
}

Console.Write("First array, input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("First array, input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Second array, input a number of rows: ");
int secondrows = Convert.ToInt32(Console.ReadLine());
Console.Write("Second array, input a number of columns: ");
int secondcolumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
int[,] secondmyArray = CreateRandom2dArray(secondrows, secondcolumns, minValue, maxValue);
Show2dArray(secondmyArray);
if (columns == secondrows)
{
    int[,] finelArray = DubleArray(myArray, secondmyArray);
    Console.WriteLine("The finel array is: ");
    Show2dArray(finelArray);
}
else Console.WriteLine("The multiplication of First and Second Arrays is unable, becouse first columns != second rows!!!");
 */

/* 
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2

int[,,] CreateRandom3dArray(int rows, int columns, int plane)
{
    int[,,] array = new int[rows, columns, plane];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < plane; k++)
            array[i,j,k] = new Random().Next(10, 100);
    return array;
}
void Show3dArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $"{array[i,j,k]} ({i},{j},{k}) ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
Console.Write("Input a number of X: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of Y: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of Z: ");
int plane = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] myArray = CreateRandom3dArray(rows, columns, plane);
Show3dArray(myArray);


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/* 
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a number of rows and columns: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] spiral2darray = new int[rows, rows];

int count = 1;
int i = 0;
int j = 0;

while (count <= spiral2darray.GetLength(0) * spiral2darray.GetLength(1))
{
  spiral2darray[i, j] = num;
  num++;
  count++;
  if (i <= j + 1 && i + j < spiral2darray.GetLength(1) - 1) j++;
  else if (i < j && i + j >= spiral2darray.GetLength(0) - 1) i++;
  else if (i >= j && i + j > spiral2darray.GetLength(1) - 1) j--;
  else i--;
}

Show2dArray(spiral2darray);

 */