// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/* void NumDegree(int num, int step)
{
    int result = 1;
    for(int i = 1; i <= step; i++) result = result * num;
    
Console.WriteLine("The result is: " + result);
}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a degree of number: ");
int step = Convert.ToInt32(Console.ReadLine());

NumDegree(num, step);
Console.WriteLine();  */


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/* 
int SumOfNum(int num)
{
    int size = num;
    int NewNum = 0;
    int sum = 0;

    while (size > 0)
    {int numLst = size % 10;
    NewNum = (NewNum * 10) + numLst;
    size = size/10;
    sum = sum + numLst; 
    }
    return sum;
}

Console.Write ("Input a number: ");
int number = Convert.ToInt32 (Console.ReadLine());

int result = SumOfNum(number);
Console.WriteLine($"Sum the elements of {number} is {result}");
 */

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray(int size = 8)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Please, input of elements: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[" + array[i] + ", ");
        else
        {
            if(i == array.Length - 1) Console.Write(array[i] + "]");
            else
            {
                Console.Write(array[i] + ", ");
            }
        }
    }
}

int [] myArray = CreateArray();

Console.Write("The massiv of eigth elements is: ");
ShowArray(myArray);



