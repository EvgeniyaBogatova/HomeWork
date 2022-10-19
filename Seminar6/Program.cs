// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// void Count ()
// {
//     Console.WriteLine("Hello. Please, write down how many numbers you want to enter: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int count = 0;
//     for (int i = 1; i <= size; i++)
//         {
//         Console.Write("Input number: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         if (n > 0)
//             count++;
//         }
//     Console.WriteLine("The number of numbers is greater than zero is " + count);
// }

// Count();


// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectPoint(int k1, int b1, int k2, int b2)
{
    if (k1 == k2 && b1 == b2)
        Console.WriteLine("These lines coincide");
    else
        if (k1 == k2 && b1 != b2)
            Console.WriteLine("These lines is parallel lines and its will not intersect");
        else
            {
            double n = b2 - b1;
            double m = k1 - k2;
            double x = n / m;   //double x = (b2-b1)/(k1-k2);
            double y = k1 * x + b1;
          
            Console.WriteLine($"These lines will intersect at the point ({x}; {y})");
            }
}

Console.WriteLine("The straight of line is given by the formula: y = k * x + b");
Console.Write("Input angle coefficient k for the first line: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input displacement b for the first line: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Now input angle coefficient k for the second line: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Finally input displacement b for the second line: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"All right! The straight of your first line is : y = {k1} * x + {b1}");
Console.WriteLine($"And the straight of your second line is : y = {k2} * x + {b2}");

IntersectPoint(k1, b1, k2, b2);
