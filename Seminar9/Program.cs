// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNumbers (int num)
{
    if (num != 1)
    {
        if (num > 1)
    {       Console.Write (num + " ");
            ShowNumbers (num - 1);
    }   
        if (num < 1)
    {
            Console.Write (num + " ");
            ShowNumbers (num + 1);
    }
    }
    else
    Console.Write ("1");
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNumbers(num);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumOfNumbers (int num1, int num2)
// {
//     if (num1 > num2)
//         return num1 += SumOfNumbers(num1 - 1, num2);
//     if (num2 > num1)
//         return num2 += SumOfNumbers(num2 - 1, num1);
//     else
//         return num1;

// }

// Console.Write("Input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Sum of numbers between {num1} and {num2} is {SumOfNumbers(num1, num2)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
