// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int [,] Create2DArray()
// {
//     Console.WriteLine("Set the number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Set the number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Input min possible value: ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Input max possible value: ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int[rows,columns];
// for (int i = 0; i < rows; i++)
//     for (int j = 0; j < columns; j++)
//         array[i,j] = new Random().Next(minValue, maxValue);
        
// return array;
// }

// void Show2DArray (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");
//         Console.WriteLine();
//     }
// }

// void BubbleRowsArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1)-1; j++)
//             for (int count = j; count >= 0; count--)
//                 if (array[i,count] < array [i, count+1])
//                     {
//                     int temp = array[i,count];
//                     array[i,count] = array [i, count+1];
//                     array [i, count+1] = temp;
//                     }
// }

// int [,] myArray = Create2DArray();
// Show2DArray (myArray);
// BubbleRowsArray(myArray);
// Console.WriteLine();
// Show2DArray(myArray);
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [,,] Create3DArray()
{
    // Console.WriteLine("Set the number of rows: ");
    // int rows = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Set the number of columns: ");
    // int columns = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Input min possible value: ");
    // int minValue = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Input max possible value: ");
    // int maxValue = Convert.ToInt32(Console.ReadLine());
bool [] onceArray = new bool [89];
for (int i = 0; i < onceArray.Length; i++)
    onceArray[i] = false;

int [, ,] array = new int[2,2,2];
for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
        for (int k = 0; k < array.GetLength(2); k++)
            {
            do
            array[i,j,k] = new Random().Next(10,100);
            while (onceArray[array[i,j,k]-10]);
            onceArray[array[i,j,k]-10] = true;
            }
return array;
}

void Show3DArray (int [,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
        {
        for (int i = 0; i < array.GetLength(0); i++)
            {for (int j = 0; j < array.GetLength(1); j++)
                
                Console.Write(array[i,j,k] + $"({i},{j},{k})" + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
            }
        Console.WriteLine();
        
}
    
Show3DArray (Create3DArray());
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
