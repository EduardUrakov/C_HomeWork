
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/* 
void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
}
Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNums(num);
 */

 
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*  
int OutPutSumNums(int M, int N)
{
    if(M == N) return M;
    if (M < N) return N + OutPutSumNums(M, N - 1);
    else return N + OutPutSumNums(M, N + 1);
}

Console.WriteLine("Input a first number: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number: ");
int N = Convert.ToInt32(Console.ReadLine());

int sumofnum = OutPutSumNums(M,N);
Console.WriteLine($"The sum of numbers is:{sumofnum}");
 */
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
 */

 int Ackerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ackerman(m - 1, 1);
  else return Ackerman(m - 1, Ackerman(m, n - 1));
}

Console.WriteLine("Input a first number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number n: ");
int n = Convert.ToInt32(Console.ReadLine());

int funcackerman = Ackerman(m,n);
Console.WriteLine($"The function of Ackerman is:{funcackerman}");
