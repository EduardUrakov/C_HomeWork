// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/* 
int NumOfElement(int num)
{
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Please input a number {i + 1}: ");
        int z = Convert.ToInt32(Console.ReadLine());
        if (z > 0) count++;
    }
return count;
}
Console.Write("Please input an elements: ");
int num = Convert.ToInt32(Console.ReadLine());
int newcount = NumOfElement(num);
Console.WriteLine();
Console.WriteLine($"The elements of number more than 0 is: {newcount}");
Console.WriteLine();
 */

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Console.Write("Input point k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input point b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input point k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input point b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
        
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
x = Math.Round(x, 2);
y = Math.Round(y, 2);

Console.WriteLine($"The intersection point is:({x};{y})");
Console.WriteLine();




