// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Count ()
{
    Console.WriteLine("Hello. Please, write down how many numbers you want to enter: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 1; i <= size; i++)
        {
        Console.Write("Input number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 0)
            count++;
        }
    Console.WriteLine("The number of numbers is greater than zero is " + count);
}

Count();


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

