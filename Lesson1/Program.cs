﻿//Задание 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 != num2)
//     if (num1 > num2)
//         Console.WriteLine("max number is " + num1);
//     else
//         Console.WriteLine("max number is " + num2);

// else
//     Console.WriteLine("These numbers are equal");

// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input threed number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {    
//     if (num1 > num3)
//     Console.WriteLine("Max number is " + num1);
//     else
//     Console.WriteLine("Max number is " + num3);
// }
// else
// {
//     if (num2 > num3)
//     Console.WriteLine("Max number is " + num2);
//     else
//     Console.WriteLine("Max number is " + num3);
// }

//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
    Console.WriteLine("This number is even");
else
    Console.WriteLine("Thris number is an odd");
