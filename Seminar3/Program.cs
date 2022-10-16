// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void Palindrom (string num)
// {
//     if (num.Length == 5)
//         if (num[0]==num[4] && num[1]==num[3])
//         Console.WriteLine($"Your number {num} is palindrom");
//         else
//         Console.WriteLine($"Your number {num} is not palindrom");
//     else
//     Console.WriteLine("Uncorrect input");
// }

// Console.Write("Input integer positive five-digit number: ");
// string a = Console.ReadLine();
// Palindrom(a);

// Задача 1.1 Если число любой длины

// void Pal (string num)
// {
//     for (int i = 0; i <= num.Length / 2; i++)
//     {
//             for (int j = num.Length - 1; j>=i; j--)
//         { 
//         if (num[i] == num[j])
//             Console.WriteLine($"Your number {num} is palindrom");
//         else
//             Console.WriteLine($"Your number {num} is not palindrom");
//         }
//     }
// }

// Console.Write("Input integer positive number: ");
// string a = Console.ReadLine();
// Pal(a);

// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 3

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void ThirdPower (int num)
{
    if (num > 0)
        for (int i = 1; i <= num; i++)
            Console.Write(i*i*i + " ");
    else
        for (int i = -1; i >= num; i--)
            Console.Write(i*i*i + " ");
}

Console.Write("Input integer number: ");
int N = Convert.ToInt32 (Console.ReadLine());
if (N == 0)
Console.WriteLine("Third Power is 0");
else
ThirdPower (N);