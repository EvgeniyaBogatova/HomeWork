//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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
//// for (int i = 0; i < rows; i++)
//     for (int j = 0; j < columns; j++)
//         array[i,j] = Math.Round((minValue+ (maxValue-minValue)*new Random().Nextint()),2);
//         // array[i,j] = Math.Round((new Random().Next(minValue,maxValue) + new Random().Nextint()),2);
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

// int [,] myArray = Create2DArray();
// Show2DArray (myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

// void GetElementValue (int [,] array, int row, int column)
// {
//     if (row <= array.GetLength(0) && column <= array.GetLength(1))
//         Console.WriteLine($"Element on {row} line and {column} column is {array[row-1,column-1]}");
//     else
//         Console.WriteLine("Element missing");
// }

// Console.WriteLine("Set the position of the element");
// Console.WriteLine("Set the row number: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Set the column number: ");
// int column = Convert.ToInt32(Console.ReadLine());

// GetElementValue (myArray, row, column);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] Create2DArrayInt()
{
    Console.WriteLine("Set the number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Set the number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[rows,columns];
for (int i = 0; i < rows; i++)
    for (int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minValue,maxValue+1);
return array;
}

void Show2DArrayInt (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

void ArithMeanOfColumns (int [,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
        {
        int sumOfElements = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sumOfElements += array[i,j];
        float meanArith = (float)sumOfElements/(float)array.GetLength(0);
        Console.Write(meanArith + " ");
        }
}

int [,] newArray = Create2DArrayInt();
Show2DArrayInt (newArray);
// double[] columnArray = ArithMeanOfColumns(newArray);
Console.WriteLine();
ArithMeanOfColumns(newArray);


