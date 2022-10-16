﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size)
{ 
int[] array = new int[size];
for (int i = 0; i < size; i++)
    array[i] = new Random().Next(100, 1000);
return array;
}

void ShowArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
    Console.Write(array[i]+ " ");
Console.WriteLine();
}

int NumberOfEver (int[] array)
{
int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
        count++;
return count;
}

Console.Write("Input length of array: ");
int lenght=Convert.ToInt32(Console.ReadLine());

int[] ArrayNew = CreateRandomArray(lenght);
ShowArray(ArrayNew);
Console.WriteLine("Number of ever numbers in an array is " + NumberOfEver(ArrayNew));



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76