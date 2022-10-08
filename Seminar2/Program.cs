//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int RemoveSecond(int num)
{
     int sec = num / 10 % 10;
 return sec;
 }

Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= -100 && number > -1000)
{
    number = number*(-1);
    int des = RemoveSecond(number);
    Console.WriteLine($"Second digit of -{number} is {des}");
}
else
    if (number >= 100 && number < 1000)
    {
        int des = RemoveSecond(number);
        Console.WriteLine($"Second digit of {number} is {des}");
    }
    else
        Console.WriteLine("Uncorrect imput");



//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.




//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
