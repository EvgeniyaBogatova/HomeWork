﻿// задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int PowerOf(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
        res = res * a;
return res;
}

Console.Write("Input integer first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer positive second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 > 0)
    Console.WriteLine($"Number {num1} to power {num2} is {PowerOf(num1, num2)}");
else if (num2==0)
    Console.WriteLine($"Number {num1} to power {num2} is 1");
else
Console.WriteLine("Uncorrect input");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
// int GetSum(int a)
// {
// int res=0;
// while (a>0)
// { res=res+ a%10;
// a=a/10;
// }}
// Console.Write("Input number: ");
// num=Convert.ToUInt32(Console.ReadLine());
// Console.WriteLine(GetSum(num));

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// m = 5 -> [1, 2, 5, 7, 19]

// m = 3 -> [6, 1, 33]
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// { int[] array=new int[size];
// for (int i=0; i<size; i++)
// array[i] = new Random(). New(minValue, maxValue+1);
// return array;
// }

// void ShouArray(int [] array)
// {
// for (int i=0; I<array.lenght; i++)
// Console.Write(array[i]+ " ");
// Console.WriteLine();
// }

// Console.Write("Input length of array: ");
// int lenght=Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal of numbers : ");
// int num1=Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximal of numbers: ");
// int num2=Convert.ToInt32(Console.ReadLine());

// int[] ArrayNew = CreateRandomArray(lenght, num1, num2);
// ShowArray;