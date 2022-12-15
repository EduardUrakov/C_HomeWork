// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/* 
int PalindNum(int num)
{
    int NewNum = 0;
    int size = num;
    while(size > 0)
    {
        int NumLst = size % 10;
        NewNum = (NewNum * 10) + NumLst;
        size = size/10;
    }
    int result = NewNum;
    if(NewNum == num)
    {
        Console.Write("Yes! Its a Palindrome number!" + NewNum);
    }
    else
    {
        Console.Write("No! Its NOT a Palindrome number!" + NewNum);
    }
    return result;
}
           
Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int RevNum = PalindNum(num);
Console.WriteLine();
   */
 
// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/* 
double LengthCoord3D(double xA, double xB, double yA, double yB, double zA, double zB)
{
    double xN = xB - xA;
    double yN = yB - yA;
    double zN = zB - zA;
    double catetXY = Math.Sqrt(Math.Pow(xN, 2) + Math.Pow(yN, 2));
    double length = Math.Sqrt(Math.Pow(catetXY, 2) + Math.Pow(zN, 2));
    return Math.Round(length, 2);
}
Console.WriteLine("Please, input X for point A: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input Y for point A: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input Z for point A: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input X for point B: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input Y for point B: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input Z for point B: ");
double zB = Convert.ToDouble(Console.ReadLine());

double result = LengthCoord3D(xA, xB, yA, yB, zA, zB);
Console.WriteLine("The length of 3D coordinate is " + result);
 */
// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/* 
void CubOfNum(int number)
{
    for(int i = 1; i <= number; i++)
    { Console.Write(Math.Pow(i, 3) + " ");
    }
}
Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The series of cubs of numbers:");
CubOfNum(num);
 */
