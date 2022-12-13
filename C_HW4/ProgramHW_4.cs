// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void NumDegree(int num, int step)
{
    int result = 1;
    
    for(int i = 1; i <= step; i++)
    {
        result = result * num;
    }
    Console.WriteLine("The result is: " + result);
}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a degree of number: ");
int step = Convert.ToInt32(Console.ReadLine());

NumDegree(num, step);
Console.WriteLine(); 


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


