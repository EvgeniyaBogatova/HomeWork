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

// Задача 1.1 Если число любой длины - палиндром?

// bool Pal (string num)
// {
//     char minus = '-';   // Символ в символьную переменную заносится в одинарных кавычках
//     int i = 0;          
//     if (num[0] == minus) 
//        i = 1;           // Если первый знак '-', то считать со второго символа, иначе с первого
//  int j = num.Length - 1;
//     while (i <= j)
//     {
//         if (num[i] == num[j])
//             {i++;
//             j--;}
//         else
//             return false;
//             }
//     return true;
//       }

// Console.Write("Input integer positive number: ");
// string a = Console.ReadLine();
// if (Pal(a))
// Console.WriteLine($"Your number {a} is palindrom");
// else
// Console.WriteLine($"NO, your number {a} is not palindrom");


// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
{
    
    double res = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));
    res = Math.Round(res, 2);
    return res;
}
    
Console.WriteLine("Set the coordinates of the FIRST point.");
Console.Write("Enter the coordinate x of the first point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate y of the first point: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate z of the first point: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("All right!");
Console.WriteLine("Now set the coordinates of the SECOND point.");
Console.Write("Enter the coordinate x of the second point: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate y of the second point: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the coordinate z of the second point: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Well done!");
Console.WriteLine();
Console.WriteLine("Distance between first and second points is " + Distance(x1, y1, z1, x2, y2, z2));


// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void ThirdPower (int num)
// {
//     if (num > 0)
//         for (int i = 1; i <= num; i++)
//             Console.Write(i*i*i + " ");
//     else
//         for (int i = -1; i >= num; i--)
//             Console.Write(i*i*i + " ");
// }

// Console.Write("Input integer number: ");
// int N = Convert.ToInt32 (Console.ReadLine());
// if (N == 0)
// Console.WriteLine("Third Power is 0");
// else
// ThirdPower (N);