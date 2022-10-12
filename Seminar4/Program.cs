// задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int PowerOf(int a, int b)
// {
//     int res = 1;
//     for (int i = 1; i <= b; i++)
//         res = res * a;
// return res;
// }

// Console.Write("Input integer first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input integer positive second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2 > 0)
//     Console.WriteLine($"Number {num1} to power {num2} is {PowerOf(num1, num2)}");
// else if (num2==0)
//     Console.WriteLine($"Number {num1} to power {num2} is 1");
// else
// Console.WriteLine("Uncorrect input");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int GetSum(int a)
// {
// int res = 0;
// while (a > 0)
// { 
//     res = res + a % 10;
//     a = a / 10;
// }
// return res;
// }
// Console.Write("Input integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine($"Sum of the digits of {num} is {GetSum(Math.Abs(num))}");

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{ 
int[] array = new int[size];
for (int i = 0; i < size; i++)
    array[i] = new Random().Next(minValue, maxValue + 1);
return array;
}

void ShowArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
Console.Write(array[i]+ " ");
Console.WriteLine();
}

Console.Write("Input length of array: ");
int lenght=Convert.ToInt32(Console.ReadLine());
Console.Write("Input minimal of numbers : ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximal of numbers: ");
int num2=Convert.ToInt32(Console.ReadLine());

int[] ArrayNew = CreateRandomArray(lenght, num1, num2);
ShowArray(ArrayNew);