
/* 
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");                       
    }
}
 */

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/* 
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];             

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int EvenNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        int newNum = array[i] % 2;
        if(newNum != 1) count++;
    }
    return count;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size);
ShowArray(myArray);
Console.WriteLine();
int result = EvenNum(myArray);
Console.WriteLine($"The number of even index's is: {result}");
 */

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
 
/* 
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];             

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}    

int SumOddPos(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum; 
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
Console.WriteLine($"Our array is: ");
ShowArray(myArray);
Console.WriteLine();
int NewSum = SumOddPos(myArray);
Console.WriteLine($"The sum of numbers in odd position is: {NewSum}: "); 

 */
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];             

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();   
    }
    return array;
}    

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");                       
    }
}

double MaxMinDif (double[]array)
{
    double maxNum = 0;
    double minNum = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxNum) 
        {
            maxNum = array[i]; 
        }
        if(array[i] < minNum)
        {
            minNum = array[i];
        }    
        
    }
    double Dif = maxNum - minNum;
    return Dif;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size, minValue, maxValue);
Console.WriteLine($"Our array is: ");
ShowArray(myArray);
Console.WriteLine();
double Result = MaxMinDif(myArray);
Console.Write($"The different of max and min numbers is: {Result}");
