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

str [] GetStringThree (str [])
{
int [] array = new int [str.GetLength];

int count = 0;
int j = 0;
for (int i = 0; i < str.GetLength; i++)
    if (str[i].GetLength <=3 )
        {array[j] = i;
        count ++;
        j++;}
    
string [] newArray = new string [count];
j=0;
for (int i = 0; i < count; i++)
    {newArray[i] = str[array[j]];
    j++;}
return newArray;
}

