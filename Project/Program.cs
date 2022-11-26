str [] InputArray ()
{
Console.WriteLine("Input length of array: ");
int length = Convert.ToInt32(Console.ReadLine());

str[] arrayString = new array[length];
for (int i = 0; i < length; i++)
    {
    Console.WriteLine("Input string: ");
    arrayString[i] = Console.ReadLine();
    }
return arrayString;
}

