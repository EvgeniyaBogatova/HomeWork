//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int RemoveSecond(int num)
// {
// int sec = num / 10 % 10;
//  return sec;
//  }

// Console.Write("Input three-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number <= -100 && number > -1000)
// {
//     number = -number;
//     Console.WriteLine($"Second digit of -{number} is {RemoveSecond(number)}");
// }
// else
//     if (number >= 100 && number < 1000)
//         Console.WriteLine($"Second digit of {number} is {RemoveSecond(number)}");
//     else
//         Console.WriteLine("Uncorrect imput");



//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int GiveThird (int n)
// {
//     while (n > 999 || n < -999)
//         n = n / 10;
// return n%10;
// }
  
// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 100 && num > -100)
//     Console.WriteLine("Third digit is absent");
//     else
//     {if (num < -99)
//         Console.WriteLine($"Third digit of {num} is {-GiveThird (num)}");
//     else
//         Console.WriteLine($"Third digit of {num} is {GiveThird (num)}");}



//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Weekend(int num)
{
    if (num == 6 || num == 7)
    return true;
    else
    return false;}

Console.Write("Input number day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 0 && day < 8)
    {if (Weekend(day))
        Console.WriteLine("It is WEEKEND!");
    else
        Console.WriteLine("O, no. It is workday");}
else
    Console.WriteLine("Days of the week is only seven, try again");