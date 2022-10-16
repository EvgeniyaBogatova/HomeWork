// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size)
// { 
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
//     array[i] = new Random().Next(100, 1000);
// return array;
// }

// void ShowArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
//     Console.Write(array[i]+ " ");
// Console.WriteLine();
// }

// int NumberOfEver (int[] array)
// {
// int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if (array[i] % 2 == 0)
//         count++;
// return count;
// }

// Console.Write("Input length of array: ");
// int lenght=Convert.ToInt32(Console.ReadLine());

// int[] ArrayNew = CreateRandomArray(lenght);
// ShowArray(ArrayNew);
// Console.WriteLine("Number of ever numbers in an array is " + NumberOfEver(ArrayNew));


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int min, int max)
// { 
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
//     array[i] = new Random().Next(min, max);
// return array;
// }

// void ShowArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
//     Console.Write(array[i]+ " ");
// Console.WriteLine();
// }

// int GiveSummEvenPosition (int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i += 2)
//     sum += array[i];
// return sum;
// }

// Console.Write("Input length of array: ");
// int length=Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min volue of array: ");
// int minVolue=Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max volue of array: ");
// int maxVolue=Convert.ToInt32(Console.ReadLine());

// int[] Array02 = CreateRandomArray(length, minVolue, maxVolue);
// ShowArray(Array02);
// Console.WriteLine("Sum digits of even positions in array is " + GiveSummEvenPosition(Array02));


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateArray(int size)
{ int[] array = new int[size];
for (int i = 0; i < size; i++)
{
     Console.Write($"Input the value element of the index {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());}
return array;
}

void ShowArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
    Console.Write(array[i]+ " ");
Console.WriteLine();
}

int Diff(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i] < min)
        min = array[i];
        else
        {
            if (array[i] > max)
            max = array[i];
        }
    }
    int res = max - min;
    return res;
}


Console.Write("Input length of array: ");
int lenght=Convert.ToInt32(Console.ReadLine());
int[] Array03 = CreateArray(lenght);
ShowArray(Array03);
Console.WriteLine("Differents between maximal and minimal digits in array is " + Diff(Array03));
