string[] firstarray = new string[10] { "first", "second", "hi", "white", "you", "array", "control", "w8", "me", "write" };
string[] secondarray = new string[firstarray.Length];
void FillSecondArray(string[] firstarray, string[] secondarray)
{
    int count = 0;
    for (int i = 0; i < firstarray.Length; i++)
    {
        if (firstarray[i].Length <= 3)
        {
            secondarray[count] = firstarray[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FillSecondArray(firstarray, secondarray);
PrintArray(secondarray);