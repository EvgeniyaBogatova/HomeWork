﻿//Задание 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 != num2)
    if (num1 > num2)
        Console.WriteLine("max number is " + num1);
    else
        Console.WriteLine("max number is " + num2);

else
    Console.WriteLine("These numbers are equal");