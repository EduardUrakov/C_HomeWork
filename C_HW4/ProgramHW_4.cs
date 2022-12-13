// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void NumDeg(int num, int step)
{
int result = 1;
if(step == 0)
{
    result = 0;
    Console.WriteLine(result);
}
else 
    for(int size = 1; size <= step; size++)
    {
        result = result * step;
        Console.WriteLine(result);
    }
    for(int size =1; size >= step; size--)
    {
        result = result / step;
        Console.WriteLine(result);
    }
}
Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a degree of number: ");
int step = Convert.ToInt32(Console.ReadLine());

(step);


/* 
Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);
 */

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


