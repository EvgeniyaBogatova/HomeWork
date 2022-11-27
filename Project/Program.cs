// string[] InputArray ()
// {
// Console.WriteLine("Input length of array: ");
// int length = Convert.ToInt32(Console.ReadLine());

// string[] arrayString = new string[length];
// for (int i = 0; i < length; i++)
//     {
//     Console.WriteLine("Input string: ");
//     arrayString[i] = Console.ReadLine();
//     }
// return arrayString;
// }

string[] GetStringThree (string[] array)
{
int n = array.Length;
int [] index = new int [n];

int count = 0;
int j = 0;
for (int i = 0; i < n; i++)
    {
    string s = array[i];
    int v = s.Length;
    if (v <=3 )
        {index[j] = i;
        count ++;
        j++;}
    }
    
string [] newArray = new string [count];
j=0;
for (int i = 0; i < count; i++)
    {newArray[i] = array[index[j]];
    j++;}
return newArray;
}

void ShowArray (string [] array)
{
int n =  array.Length;
for (int i = 0; i < n; i++)
    Console.Write(array[i] + "; ");
}

string [] myArray = {"fyd", "jbdskj djhfbjd dfhb", "fiud", "ufd", "2", "jfdie"};
ShowArray (myArray);
Console.WriteLine();
ShowArray (GetStringThree(myArray));



